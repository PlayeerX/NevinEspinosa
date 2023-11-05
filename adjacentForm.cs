using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPC102AdjacencyIncident
{
    public partial class adjacentForm : Form
    {
        private Graph graph;
        private GViewer viewer;

        public adjacentForm(Graph inputGraph)
        {
            InitializeComponent();
            graph = inputGraph;
            viewer = new GViewer
            {
                Dock = DockStyle.Fill
            };
            panelGraph.Controls.Add(viewer);
            DisplayGraph();
            DisplayAdjacencyMatrix();
            DisplayAdjacencyList();
        }

        //displaying graph funct gamit MSagl viewer link sa Panel na control
        private void DisplayGraph()
        {
            viewer.Graph = graph;
            panelGraph.Controls.Add(viewer);
            viewer.Invalidate();
        }

        //displaying matrix function 
        private void DisplayAdjacencyMatrix()
        {
            adjacencyMatrixGridView.Columns.Clear();
            adjacencyMatrixGridView.Rows.Clear();

            foreach (var node in graph.Nodes)
            {
                adjacencyMatrixGridView.Columns.Add(node.Id, node.Id);
            }

            for (int i = 0; i < graph.NodeCount; i++)
            {
                int rowIndex = adjacencyMatrixGridView.Rows.Add();

                for (int j = 0; j < graph.NodeCount; j++)
                {
                    adjacencyMatrixGridView.Rows[rowIndex].Cells[j].Value = "0";
                }

                adjacencyMatrixGridView.Rows[rowIndex].HeaderCell.Value = graph.Nodes.ElementAt(i).Id;
            }

            foreach (var edge in graph.Edges)
            {
                int rowIndex = FindNodeIndex(edge.SourceNode);
                int columnIndex = FindNodeIndex(edge.TargetNode);

                adjacencyMatrixGridView.Rows[rowIndex].Cells[columnIndex].Value = "1";
                adjacencyMatrixGridView.Rows[columnIndex].Cells[rowIndex].Value = "1";
            }

            adjacencyMatrixGridView.Refresh();
        }

        //displaying list funct
        private void DisplayAdjacencyList()
        {
            foreach (var node in graph.Nodes)
            {
                var neighbors = graph.Edges.Where(e => e.SourceNode == node || e.TargetNode == node)
                                           .Select(e => e.SourceNode == node ? e.TargetNode.Id : e.SourceNode.Id)
                                           .Distinct()
                                           .OrderBy(id => id);
                adjacencyListTextBox.AppendText("|"+ node.Id + "| -> |" + string.Join("| -> |", neighbors) + "|"+ Environment.NewLine);
            }
        }
        //funct for node finding
        private int FindNodeIndex(Node node)
        {
            for (int i = 0; i < adjacencyMatrixGridView.Columns.Count; i++)
            {
                if (adjacencyMatrixGridView.Columns[i].Name == node.Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
