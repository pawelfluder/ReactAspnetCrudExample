import React, { useEffect, useState } from 'react';
import { Treebeard } from 'react-treebeard';
import parseXml from 'xml2js';
import '../App.css';

interface Country {
  id: string;
  name: string;
  capital: string;
  surfaceAreaKm2: number;
  populationMln: number;
  president: string;
  currency: string;
}

interface TreeNode {
  id: string;
  name: string;
  children?: TreeNode[];
}

function TreeView() {
  const [treeData, setTreeData] = useState<TreeNode[]>([]);
  const [newCountry, setNewCountry] = useState<Country>({
    id: '',
    name: '',
    capital: '',
    surfaceAreaKm2: 0,
    populationMln: 0,
    president: '',
    currency: '',
  });

  useEffect(() => {
    populateDataCountries();
  }, []);

  const handleAddCountry = () => {
    const newTreeNode: TreeNode = {
      id: newCountry.id,
      name: newCountry.name,
    };

    setTreeData([...treeData, newTreeNode]);
    // Reset the newCountry state to clear the input fields
    setNewCountry({
      id: '',
      name: '',
      capital: '',
      surfaceAreaKm2: 0,
      populationMln: 0,
      president: '',
      currency: '',
    });
  };

  const handleSaveChanges = () => {
    // Assuming your backend supports saving changes
    // You may need to adjust the API endpoint and method based on your backend implementation

    fetch("https://localhost:5173/save-changes", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(treeData),
    })
      .then((response) => response.json())
      .then((data) => {
        console.log("Changes saved successfully:", data);
      })
      .catch((error) => {
        console.error("Error saving changes:", error);
        // Handle error if needed
      });
  };

  const handleClearAll = () => {
    setTreeData([]);
  };

  const handleLoadXML = async () => {
    const input = document.createElement('input');
    input.type = 'file';

    input.addEventListener('change', async (event) => {
      const file = (event.target as HTMLInputElement).files?.[0];

      if (file) {
        const content = await readFileContent(file);
        const parsedData = await parseXMLData(content);
        setTreeData(parsedData);
      }
    });

    // Trigger file input click
    input.click();
  };

  const readFileContent = (file: File): Promise<string> => {
    return new Promise((resolve, reject) => {
      const reader = new FileReader();

      reader.onload = (event) => {
        if (event.target) {
          resolve(event.target.result as string);
        }
      };

      reader.onerror = (error) => {
        reject(error);
      };

      reader.readAsText(file);
    });
  };

  const parseXMLData = async (xmlContent: string): Promise<TreeNode[]> => {
    return new Promise((resolve, reject) => {
      parseXml.parseString(xmlContent, (err, result) => {
        if (err) {
          reject(err);
        } else {
          const treeData = convertXmlToTree(result);
          resolve(treeData);
        }
      });
    });
  };

  const convertXmlToTree = (xmlObject: any): TreeNode[] => {
    // Implement conversion logic from XML object to tree structure
    // You need to adapt this based on the actual structure of your XML data

    const rootNode: TreeNode = {
      id: 'root',
      name: 'Root', // You can change the name as needed
      children: [],
    };

    // Placeholder implementation
    console.log('Converted XML to Tree:', xmlObject);
    // You need to implement the actual conversion here

    return [rootNode];
  };

  return (
    <div>
      <h1 id="tabelLabel">Countries Tree View</h1>

      <div style={{ textAlign: 'left' }}>
        <button onClick={handleClearAll}>Clear All</button>
        <button onClick={handleSaveChanges}>Save Changes</button>
        <button onClick={handleLoadXML}>Load XML</button>
      </div>

      <Treebeard data={treeData} onToggle={() => {}} />

    </div>
  );

  async function populateDataCountries() {
    var url = "https://localhost:5173/countries";
    const response = await fetch(url);
    const data = await response.json();

    console.log("countries; response.json()");
    console.log(data);
    // Convert data to TreeNode format if needed
    // Placeholder conversion
    const treeNodes = data.map((country: Country) => ({ id: country.id, name: country.name }));
    setTreeData(treeNodes);
  }
}

export default TreeView;