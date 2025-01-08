import { useState, useEffect } from "react";
import TreeView from "./TreeViewXml.tsx"; // zmiana nazwy pliku
//import xmlData from "../Data/XmlData.tsx"; // dane XML
import useTraverseTree, { ExplorerItem } from "./UseTraverseTreeXml.tsx"; 
import xmlJs from 'xml-js';

function CountriesTree() {
  
  const root: ExplorerItem = {
    id: "1",
    name: "New Item",
    isFolder: true,
    items: [],
    attributes: {},
  };
  const [explorerData, setExplorerData] = useState<ExplorerItem>(root);
  PopulateData();
  const { insertNode } = useTraverseTree();

  useEffect(() => {
    PopulateData();
  }, []);

  const handleInsertNode = (folderId: string, item: string, isFolder: boolean, attributes?: Record<string, string>) => {
    const finalTree = insertNode(explorerData, folderId, item, isFolder, attributes);
    setExplorerData((prevExplorerData) => ({
      ...prevExplorerData,
      items: finalTree.items,
    }));
  };

  async function PopulateData() {
    var url = "https://localhost:5173/countriestree";

    fetch(url)
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.text();
      })
      .then(resultData => {
        let jsonData = xmlJs.xml2json(resultData,  { compact: false, spaces: 4 });
        let result = JSON.parse(jsonData);
      
        console.log("CountriesTree; response.json()");
        //var type2 = typeof(result);
        var el = result.elements;
        var el0 = el[0];
        setExplorerData({
          id: el0.attributes?.id || '',
          name: el0.attributes?.name || '',
          isFolder: true,
          items: el0.elements?.map((element: any) => convertElement(element)) || [],
          attributes: el0.attributes || {},
        });
      })
      .catch(error => {
        console.error(error);
      });
  }

  const convertElement = (element: any): ExplorerItem => {
    return {
      id: element.attributes?.id || '',
      name: element.attributes?.name || '',
      isFolder: element.elements ? true : false,
      items: element.elements?.map((e: any) => convertElement(e)) || [],
      attributes: element.attributes || {},
    };
  };

  return (
    <div>
      <div style={{ textAlign: 'left' }}>
        <button>Clear All</button>
        <button>Save Changes</button>
        <button>Load XML</button>
      </div>
      <TreeView handleInsertNode={handleInsertNode} explorer={explorerData} />
    </div>
  );
};
export default CountriesTree;