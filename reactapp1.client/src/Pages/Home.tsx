import React from "react";
import LogoutLink from "../Components/LogoutLink.tsx";
import AuthorizeView, { AuthorizedUser } from "../Components/AuthorizeView.tsx";
import CountriesGrid from "../Components/CountriesGrid.tsx";
import CountriesTree from "../TraverseTreeXml/CountriesTreeXml.tsx";
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';
import 'react-tabs/style/react-tabs.css';
import { SimpleTreeView } from '@mui/x-tree-view/SimpleTreeView';
import { TreeItem } from '@mui/x-tree-view/TreeItem';
// import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
// import ChevronRightIcon from '@mui/icons-material/ChevronRight';

// import jsonData from "../Data/JsonData.tsx";
// import xmlData from "../Data/XmlData.tsx";
//
import TreeView2 from 'devextreme-react/tree-view';

const Home: React.FC = () => {
  return (
    <AuthorizeView >
      <span style={{ position: 'absolute', top: 15, left: 15, textAlign: 'left'}}>
        <LogoutLink >Logout <AuthorizedUser value="email" /></LogoutLink>
      </span>
      <Tabs style={{ position: 'absolute', top: 60, left: 15, textAlign: 'left'}}>
          <TabList>
            <Tab>Grid</Tab>
            <Tab>Tree</Tab>
            <Tab>Tree2</Tab>
            <Tab>Tree3</Tab>
          </TabList>

          <TabPanel>
            <h2>Countries Tree</h2>
            <CountriesGrid />
          </TabPanel>

          <TabPanel>
            <h2>Countries Tree</h2>
            <CountriesTree />
          </TabPanel>

          <TabPanel>
            <h2>Countries Tree2</h2>
            <SimpleTreeView
              aria-label="file system navigator"
              // defaultCollapseIcon={<ExpandMoreIcon />}
              // defaultExpandIcon={<ChevronRightIcon />}
            >
              <TreeItem itemId="1" label="Applications">
                <TreeItem itemId="2" label="Calendar" />
              </TreeItem>
              <TreeItem itemId="5" label="Documents">
                <TreeItem itemId="10" label="OSS" />
                <TreeItem itemId="6" label="MUI">
                  <TreeItem itemId="8" label="index.js" />
                </TreeItem>
              </TreeItem>
              </SimpleTreeView>
            
          </TabPanel>

          <TabPanel>
            <h2>Countries Tree3</h2>
            <TreeView2>
            dataSource=xmlData
            dataStructure="plain"
            keyExpr="ID"
            displayExpr="name"
            parentIdExpr="categoryId"
            </TreeView2>
          </TabPanel>


        </Tabs>        
    </AuthorizeView>
  );
};
export default Home;