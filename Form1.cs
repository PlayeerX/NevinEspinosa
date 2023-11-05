using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace AssignmentPC102AdjacencyIncident
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnAdjacentForm_Click(object sender, EventArgs e)
        {
            try
            {
                var graph = ParseGraphInput(txtGraphInput.Text);
                if (graph != null)
                {
                    var adjacentForm = new adjacentForm(graph);
                    adjacentForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncidentForm_Click(object sender, EventArgs e)
        {
            try
            {
                var graph = ParseGraphInput(txtGraphInput.Text);
                if (graph != null)
                {
                    var incidentForm = new incidentForm(graph);
                    incidentForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Graph ParseGraphInput(string input)
        {
            var graph = new Graph();
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            bool? isDirected = null;

            foreach (var line in lines)
            {
                if (line.Contains("->"))
                {
                    if (isDirected == false)
                    {
                        throw new Exception("The input must not contain mixed types of edges.");
                    }
                    isDirected = true;
                    var tokens = line.Split(new[] { "->" }, StringSplitOptions.None);
                    graph.AddEdge(tokens[0], tokens[1]);
                }
                else if (line.Contains("-"))
                {
                    if (isDirected == true)
                    {
                        throw new Exception("The input must not contain mixed types of edges.");
                    }
                    isDirected = false;
                    var tokens = line.Split('-');
                    var edge = graph.AddEdge(tokens[0], tokens[1]);
                    edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                    edge.Attr.ArrowheadAtSource = ArrowStyle.None;
                }
                else
                {
                    throw new Exception("Invalid input format.");
                }
            }

            return graph;
        }
    }
}
