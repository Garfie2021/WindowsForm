using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
//using System.DirectoryServices.DirectoryEntry;

namespace AD操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var directoryPath = "LDAP://(ドメイン)";
            var userName = @"(ドメイン)\(ユーザアカウント名)";
            var password = "(ユーザアカウントのパスワード)";

            DirectoryEntry directoryEntry = new DirectoryEntry(directoryPath, userName, password);

            using (var searcher = new DirectorySearcher(directoryEntry))
            {
                // 一つのみ指定する場合。
                searcher.Filter = (string.Format("(objectSid={0})", txtSID.Text));

                // 複数指定する場合。
                //searcher.Filter = ("(|(objectSid=S-9-9-99-999999999-9999999999-9999999999-1000)(objectSid=S-9-9-99-999999999-9999999999-9999999999-1001))");
                var results = searcher.FindAll();

                // Iterate through each SearchResult in the SearchResultCollection.
                foreach (SearchResult searchResult in results)
                {
                    // Display the path of the object found.
                    txt結果.Text += "\r\n" + string.Format("Search properties for {0}", searchResult.Path) + "\r\n";

                    // Iterate through each property name in each SearchResult.
                    foreach (string propertyKey in
                        searchResult.Properties.PropertyNames)
                    {
                        // Retrieve the value assigned to that property name 
                        // in the ResultPropertyValueCollection.
                        ResultPropertyValueCollection valueCollection =
                            searchResult.Properties[propertyKey];

                        // Iterate through values for each property name in each 
                        // SearchResult.
                        foreach (Object propertyValue in valueCollection)
                        {
                            // Handle results. Be aware that the following 
                            // WriteLine only returns readable results for 
                            // properties that are strings.
                            txt結果.Text += string.Format("{0}:{1}", propertyKey, propertyValue.ToString()) + "\r\n";
                        }
                    }
                }

                //var result1 =  result.PropertiesLoaded();
                //return result;
            }
        }

    }
}
