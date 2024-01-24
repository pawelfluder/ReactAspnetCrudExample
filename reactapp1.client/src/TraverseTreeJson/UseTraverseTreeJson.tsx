export interface ExplorerItem {
  id: string;
  name: string;
  isFolder: boolean;
  items?: ExplorerItem[];
}

interface TraverseTreeFunctions {
  insertNode: (tree: ExplorerItem, folderId: number | string, item: string, isFolder: boolean) => ExplorerItem;
  deleteNode: () => void; // Todo
  renameNode: () => void; // Todo
}

const useTraverseTree = (): TraverseTreeFunctions => {
  const insertNode = function (
    tree: ExplorerItem,
    folderId: number | string,
    item: string,
    isFolder: boolean
  ): ExplorerItem {
    if (tree.id === folderId && tree.isFolder) {
      const newNode: ExplorerItem = {
        id: new Date().getTime().toString(),
        name: item,
        isFolder: isFolder,
        items: [],
      };

      tree.items?.unshift(newNode);

      return tree;
    }

    const updatedItems: ExplorerItem[] = tree.items?.map((ob) => {
      return insertNode(ob, folderId, item, isFolder);
    }) || [];

    return { ...tree, items: updatedItems };
  };

  const deleteNode = () => {}; // Todo

  const renameNode = () => {}; // Todo

  return { insertNode, deleteNode, renameNode };
};

export default useTraverseTree;