using Microsoft.Msagl.Core.Layout;
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
    public partial class incidentForm : Form
    {
        private Graph graph;
        private GViewer viewer;

        public incidentForm(Graph inputGraph)
        {
            InitializeComponent();
            graph = inputGraph;

            // Set up the viewer for MSAGL
            viewer = new GViewer
            {
                Dock = DockStyle.Fill
            };
            panelGraph.Controls.Add(viewer);


            DisplayGraph();
            DisplayIncidentMatrix();
            DisplayIncidentList();
        }

        private void DisplayGraph()
        {
            int edgeIndex = 1;
            foreach (var edge in graph.Edges)
            {
                edge.LabelText = $"E{edgeIndex++}";
            }
            viewer.Graph = graph;
            panelGraph.Controls.Add(viewer);
            viewer.Invalidate();
        }

        private void DisplayIncidentMatrix()
        {
            // Assuming edges are indexed and have an ID
            int numberOfEdges = graph.Edges.Count();
            int numberOfVertices = graph.Nodes.Count();

            // Initialize the matrix view for edges and vertices
            incidentMatrixGridView.ColumnCount = numberOfVertices;
            incidentMatrixGridView.RowCount = numberOfEdges;

            // Set headers for rows (edges) and columns (vertices)
            int columnIndex = 0;
            foreach (var node in graph.Nodes)
            {
                incidentMatrixGridView.Columns[columnIndex].Name = node.Id;
                columnIndex++;
            }

            int rowIndex = 0;
            foreach (var edge in graph.Edges)
            {
                incidentMatrixGridView.Rows[rowIndex].HeaderCell.Value = $"E{rowIndex + 1}"; // Label edges as E1, E2, etc.

                // For each edge, mark the incident vertices with 1
                foreach (var node in graph.Nodes)
                {
                    if (edge.Source == node.Id || edge.Target == node.Id)
                    {
                        incidentMatrixGridView.Rows[rowIndex].Cells[node.Id].Value = 1;
                    }
                    else
                    {
                        incidentMatrixGridView.Rows[rowIndex].Cells[node.Id].Value = 0;
                    }
                }

                rowIndex++;
            }

            // Adjust the view
            incidentMatrixGridView.AutoResizeColumns();
            incidentMatrixGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }


        private void DisplayIncidentList()
        {
            // Clear existing content from the TextBox
            incidentListTextBox.Clear();

            // Dictionary to hold the incident edges for each vertex
            Dictionary<string, List<string>> vertexIncidents = new Dictionary<string, List<string>>();

            // Initialize the dictionary with an empty list for each vertex
            foreach (var node in graph.Nodes)
            {
                vertexIncidents[node.Id] = new List<string>();
            }

            // Populate the dictionary with edges incident to each vertex
            int edgeIndex = 1; // Start an index for the edges
            foreach (var edge in graph.Edges)
            {
                string edgeRepresentation = $"E{edgeIndex}";

                // Add the edge to the start vertex's list
                vertexIncidents[edge.Source].Add(edgeRepresentation);

                // For undirected edges, also add it to the end vertex's list
                if (edge.Source != edge.Target) // Avoid duplicating for self-loop
                {
                    vertexIncidents[edge.Target].Add(edgeRepresentation);
                }

                edgeIndex++; // Increment the index for the next edge
            }

            // Construct the incident list string for each vertex
            foreach (var vertex in vertexIncidents.Keys)
            {
                string incidentEdges = string.Join("| -> |", vertexIncidents[vertex]);
                string vertexIncidentsRepresentation = $"|{vertex}| -> |{incidentEdges}|";
                incidentListTextBox.AppendText(vertexIncidentsRepresentation + "|"+ Environment.NewLine);
            }
        }


    }
}
