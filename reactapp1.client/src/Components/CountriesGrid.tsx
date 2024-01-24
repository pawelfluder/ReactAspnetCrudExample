import React, { useEffect, useState } from 'react';
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

function CountriesGrid() {
  const [forecasts, setForecasts] = useState<Country[]>([]);
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
    setForecasts([...forecasts, newCountry]);
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
      body: JSON.stringify(forecasts),
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
    setForecasts([]);
  };

  const handleLoadCSV = async () => {
    const input = document.createElement('input');
    input.type = 'file';
  
    input.addEventListener('change', async (event) => {
      const file = (event.target as HTMLInputElement).files?.[0];
  
      if (file) {
        const content = await readFileContent(file);
        console.log('Loaded CSV data:', content);
      }
    });
  
    // Trigger file input click
    input.click();
  };
  
  const handleLoadXML = async () => {
    const input = document.createElement('input');
    input.type = 'file';
  
    input.addEventListener('change', async (event) => {
      const file = (event.target as HTMLInputElement).files?.[0];
  
      if (file) {
        const content = await readFileContent(file);
        console.log('Loaded XML data:', content);
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

  return (
    <div style={{ textAlign: 'left', minWidth: 500 }}>
      <div style={{ textAlign: 'left' }}>
        <button onClick={handleClearAll}>Clear All</button>
        <button onClick={handleSaveChanges}>Save Changes</button>
        <button onClick={handleLoadCSV}>Load CSV</button>
      </div>

      <table>
        <thead>
          <tr>
            <th></th>
            <th>Name</th>
            <th>Capital</th>
            <th>Surface Area (km2)</th>
            <th>Population (mln)</th>
            <th>President</th>
            <th>Currency</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th><td style={{ maxWidth: '20px' }}>
                <button onClick={handleAddCountry}>Add</button></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="text" id="name" value={newCountry.name}
                onChange={(e) => setNewCountry({ ...newCountry, name: e.target.value })}/></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="text" id="capital" value={newCountry.capital}
                onChange={(e) => setNewCountry({ ...newCountry, capital: e.target.value })}/></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="number" id="surfaceAreaKm2" value={newCountry.surfaceAreaKm2}
                onChange={(e) => setNewCountry({ ...newCountry, surfaceAreaKm2: parseFloat(e.target.value) || 0 })}/></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="number" step="0.1" id="populationMln" value={newCountry.populationMln}
                onChange={(e) => setNewCountry({ ...newCountry, populationMln: parseFloat(e.target.value) || 0 })}/></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="text" id="president" value={newCountry.president}
                onChange={(e) => setNewCountry({ ...newCountry, president: e.target.value })}/></td></th>
            <th><td style={{ maxWidth: '70px' }}>
                <input style={{ maxWidth: '90px' }} type="text" id="currency" value={newCountry.currency}
                onChange={(e) => setNewCountry({ ...newCountry, currency: e.target.value })}/></td></th>
          </tr>
        </tbody>
      </table>

      <table className="table table-striped" aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Capital</th>
            <th>Surface Area (km2)</th>
            <th>Population (mln)</th>
            <th>President</th>
            <th>Currency</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map((forecast) => (
            <tr key={forecast.id}>
              <td>{forecast.name}</td>
              <td>{forecast.capital}</td>
              <td>{forecast.surfaceAreaKm2}</td>
              <td>{forecast.populationMln}</td>
              <td>{forecast.president}</td>
              <td>{forecast.currency}</td>
            </tr>
          ))}
        </tbody>
      </table>

    </div>
  );

  async function populateDataCountries() {
    var url = "https://localhost:5173/countries";
    const response = await fetch(url);
    const data = await response.json();

    console.log("countries; response.json()");
    console.log(data);
    setForecasts(data);
  }
}

export default CountriesGrid;