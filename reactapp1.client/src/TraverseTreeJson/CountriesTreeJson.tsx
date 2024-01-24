import React, { useState } from "react";
import TreeView from "./TreeViewJson.tsx";
import jsonData from "../Data/JsonData.tsx"; // tutaj zwarte są dane xml
import useTraverseTree, { ExplorerItem } from "./UseTraverseTreeJson.tsx";

const CountriesTree: React.FC = () => {
  const [explorerData, setExplorerData] = useState<ExplorerItem>(jsonData);
  const { insertNode } = useTraverseTree();

  const handleInsertNode = (folderId: string, item: string, isFolder: boolean) => {
    const finalTree = insertNode(explorerData, folderId, item, isFolder);
    setExplorerData((prevExplorerData) => ({
      ...prevExplorerData,
      items: finalTree.items,
    }));
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