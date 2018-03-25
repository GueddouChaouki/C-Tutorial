using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.AdvTree;

namespace TreeView
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent ();
            /* Node node0 = new Node ();
             Node node1 = new Node ();
             Node node2 = new Node ();
             Node node3 = new Node ();
             Node node4 = new Node ();
             Node node5 = new Node ();


             node0.Text = "animal";
             node1.Text = "lion";
             node2.Text = "cow";
             node3.Text = "Languages";
             node4.Text = "C#";
             node5.Text = "Java";

             advTree1.Nodes.Add ( node0 );
             node0.Nodes.Add ( node1 );
             node0.Nodes.Add ( node2 );
             advTree1.Nodes.Add ( node3 );
             node3.Nodes.Add ( node4 );
             node3.Nodes.Add ( node5 );
             */

            treeView1.Nodes.Add ( "animal" , "animal" , 0 , 0 );
            treeView1.Nodes[0].Nodes.Add ( "lion" , "lion" , 1 , 1 );
            treeView1.Nodes[0].Nodes.Add ( "cow" , "cow" , 1 , 1 );
            treeView1.Nodes[0].Nodes.Add ( "tiger" , "tiger" , 1 , 1 );

            treeView1.Nodes.Add ( "Languages" , "Languages" , 0 , 0 );
            treeView1.Nodes[1].Nodes.Add ( "C#" , "C#" , 1 , 1 );
            treeView1.Nodes[1].Nodes.Add ( "Java" , "Java" , 1 , 1 );
            treeView1.Nodes[1].Nodes.Add ( "C++" , "C++" , 1 , 1 );






        }

        private void Form1_Load( object sender , EventArgs e )
        {

        }

        private void advTree1_Click( object sender , EventArgs e )
        {

        }

        private void button1_Click( object sender , EventArgs e )
        {
            listBoxAdv1.Items.Clear ();
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Checked == true)
                {
                    listBoxAdv1.Items.Add ( node.Text );
                }
            }

            for (int i= 0; i< treeView1.Nodes.Count; i++)
            {
                foreach (TreeNode node in treeView1.Nodes[i].Nodes)
                {
                    if (node.Checked == true)
                    {
                        listBoxAdv1.Items.Add ( node.Text );
                    }
                }
            }
           
        }
    }
}
