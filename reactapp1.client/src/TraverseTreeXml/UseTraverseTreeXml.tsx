export interface ExplorerItem {
  id: string;
  name: string;
  isFolder: boolean;
  attributes?: Record<string, string>; // Dodane atrybuty XML
  items?: ExplorerItem[];
}

interface TraverseTreeFunctions {
  insertNode: (
    tree: ExplorerItem,
    folderId: number | string,
    item: string,
    isFolder: boolean,
    attributes?: Record<string, string> // Dodane atrybuty XML
  ) => ExplorerItem;
  deleteNode: () => void; // Todo
  renameNode: () => void; // Todo
}

const useTraverseTree = (): TraverseTreeFunctions => {
  const insertNode = function (
    tree: ExplorerItem,
    folderId: number | string,
    item: string,
    isFolder: boolean,
    attributes?: Record<string, string>
  ): ExplorerItem {
    if (tree.id === folderId && tree.isFolder) {
      const newNode: ExplorerItem = {
        id: new Date().getTime().toString(),
        name: item,
        isFolder: isFolder,
        attributes,
        items: [],
      };

      tree.items?.unshift(newNode);

      return tree;
    }

    const updatedItems: ExplorerItem[] = tree.items?.map((ob) => {
      return insertNode(ob, folderId, item, isFolder, attributes);
    }) || [];

    return { ...tree, items: updatedItems };
  };

  const deleteNode = () => {}; // Todo

  const renameNode = () => {}; // Todo

  return { insertNode, deleteNode, renameNode };
};

export default useTraverseTree;