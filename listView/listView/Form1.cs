using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace listView
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
         
            listViewEx1.Columns.Add ( "Folders" );
            ColumnHeader c = new ColumnHeader ();
            c.Text = "folders";
            listViewEx1.Columns.Add ( c );
            ColumnHeader d = new ColumnHeader ();
            d.Text = "Description";
            listViewEx1.Columns.Add ( d );
            listViewEx1.Columns.Add ( "date" );

            listViewEx1.Groups.Add ( "" , "group1" );
            listViewEx1.Groups.Add ( "" , "group2" );
            listViewEx1.Groups.Add ( "" , "group3" );
            listViewEx1.Groups.Add ( "" , "group4" );


            listViewEx1.Items.Add ( "Folder1" , 0 );
            listViewEx1.Items.Add ( "Folder2" , 0 );
            listViewEx1.Items.Add ( "Folder3" , 0 );
            listViewEx1.Items.Add ( "Folder4" , 0 );
            listViewEx1.Items.Add ( "Folder5" , 0 );
            listViewEx1.Items.Add ( "Folder6" , 0 );
            listViewEx1.Items.Add ( "Folder7" , 0 );
            listViewEx1.Items.Add ( "Folder8" , 0 );

            listViewEx1.Items[0].Group = listViewEx1.Groups[0];
            listViewEx1.Items[1].Group = listViewEx1.Groups[0];
            listViewEx1.Items[2].Group = listViewEx1.Groups[1];
            listViewEx1.Items[3].Group = listViewEx1.Groups[1];
            listViewEx1.Items[4].Group = listViewEx1.Groups[2];
            listViewEx1.Items[5].Group = listViewEx1.Groups[2];
            listViewEx1.Items[6].Group = listViewEx1.Groups[3];
            listViewEx1.Items[7].Group = listViewEx1.Groups[3];



        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }


        private void comboBoxEx1_SelectedIndexChanged( object sender , EventArgs e )
        {
            switch (comboBoxEx1.Text)
            {
                case "LargeIcons":
                    listViewEx1.View = View.LargeIcon;
                    break;

                case "List":
                    listViewEx1.View = View.List;
                    break;

                case "Details":
                    listViewEx1.View = View.Details;
                    break;

                case "SmallIcon":
                    listViewEx1.View = View.SmallIcon;
                    break;

                case "Tile":
                    listViewEx1.View = View.Tile;
                    break;

                default:
                    MessageBoxEx.Show ( "une erreur est survenue" );
                    break;

            }
        }
    }
}
