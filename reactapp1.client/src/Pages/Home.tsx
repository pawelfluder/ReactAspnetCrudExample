import React from "react";
import LogoutLink from "../Components/LogoutLink.tsx";
import AuthorizeView, { AuthorizedUser } from "../Components/AuthorizeView.tsx";
import CountriesGrid from "../Components/CountriesGrid.tsx";
import CountriesTree from "../TraverseTreeXml/CountriesTreeXml.tsx";
import { Tab, Tabs, TabList, TabPanel } from 'react-tabs';
import 'react-tabs/style/react-tabs.css';

const Home: React.FC = () => {
  return (
    <AuthorizeView >
      <span style={{ position: 'absolute', top: 15, left: 15, textAlign: 'left'}}>
        <LogoutLink >Logout <AuthorizedUser value="email" /></LogoutLink>
      </span>
      <Tabs style={{ position: 'absolute', top: 60, left: 15, textAlign: 'left'}}>
          <TabList>
            <Tab>Tree</Tab>
            <Tab>Grid</Tab>
          </TabList>

          <TabPanel>
            <h2>Countries Tree</h2>
            <CountriesTree />
          </TabPanel>

          <TabPanel>
            <h2>Countries Grid</h2>
            <CountriesGrid />
          </TabPanel>
        </Tabs>
    </AuthorizeView>
  );
};
export default Home;