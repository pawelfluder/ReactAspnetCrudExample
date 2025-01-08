import React, { useState } from "react";

interface FolderProps {
  handleInsertNode: (id: string, value: string, isFolder: boolean) => void;
  explorer: {
    id: string;
    name: string;
    isFolder: boolean;
    items?: Array<{
      id: string;
      name: string;
      isFolder: boolean;
      items?: any[];
    }>;
  };
}

const Folder: React.FC<FolderProps> = ({ handleInsertNode, explorer }) => {
  const [expand, setExpand] = useState(false);
  const [showInput, setShowInput] = useState({
    visible: false,
    isFolder: false,
  });

  const handleNewFolder = (e: React.MouseEvent, isFolder: boolean) => {
    e.stopPropagation();
    setExpand(true);
    setShowInput({
      visible: true,
      isFolder,
    });
  };

  const onAddFolder = (e: React.KeyboardEvent<HTMLInputElement>) => {
    if (e.key === "Enter" && e.currentTarget.value) {
      handleInsertNode(explorer.id, e.currentTarget.value, showInput.isFolder);

      setShowInput({ ...showInput, visible: false });
    }
  };

  if (explorer.isFolder) {
    return (
      <div>
        <div onClick={() => setExpand(!expand)} className="folder">
          <span>🌳 {explorer.name}</span>
            <button onClick={(e) => handleNewFolder(e, true)}>root +</button>
            <button onClick={(e) => handleNewFolder(e, false)}>leaf +</button>
        </div>

        <div style={{ display: expand ? "block" : "none", paddingLeft: 25 }}>
          {showInput.visible && (
            <div className="inputContainer">
              <span>{showInput.isFolder ? "🌳" : "🍁"}</span>
              <input
                type="text"
                className="inputContainer__input"
                autoFocus
                onKeyDown={onAddFolder}
                onBlur={() => setShowInput({ ...showInput, visible: false })}
              />
            </div>
          )}

          {explorer.items &&
            explorer.items.map((exp) => (
              <Folder
                handleInsertNode={handleInsertNode}
                key={exp.id}
                explorer={exp}
              />
            ))}
        </div>
      </div>
    );
  } else {
    return <span className="file">🍁 {explorer.name}</span>;
  }
};

export default Folder;