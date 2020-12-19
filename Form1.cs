using Console.Chapters.Subject8.Intermediate;
using Console.Chapters.Subject8.Junior;
using Console.Chapters.Subject8.Senoir;
using Console.Chapters.Subject9.Intermediate;
using Console.Chapters.Subject9.Junior;
using Console.Chapters.Subject9.Senior;
using Console.Device;
using Console.framework;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;
using Utilities.Forms;

namespace Console
{
    public partial class Form1 : Office2007Form
    {
        private IDeviceSubject device = new FakeDevice();
        public Form1()
        {
            InitializeComponent();
            EnableGlass = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SlashForm slash = new SlashForm();
            //slash.SetText("");
            //slash.SetSlashImg(Resource1.Slash);
            //slash.ShowDialog();
        }

        public void ShowChapter(IChapterBuilder c)
        {
            ContentBoard board = new ContentBoard();
            c.GetChapter().ShowContent(board);
            if(panel1.Controls.Count > 0)
                (panel1.Controls[0] as Form).Close();
            panel1.Controls.Clear();
            panel1.Controls.Add(board);
            board.Show();

            var chapterName = c.GetType().Name;
            var item = sideNav1.SelectedItem;

            if (item == null)   //菜单收起时item为null
                return;

            var tree = (item.Panel.Controls[0] as AdvTree);
            var snode = FindNodeInTree(tree, chapterName);
            if(snode != null)
            {
                tree.SelectedNode = snode;
            }

            Node FindNodeInTree(AdvTree t, string tagString)
            {
                foreach (var n in t.Nodes)
                {
                    Node ret = FindNode(n as Node, tagString);
                    if (ret != null)
                        return ret;
                }
                return null;
            }

            Node FindNode(Node n, string tagString)
            {
                if (n.TagString == tagString)
                    return n;
                else
                {
                    if(n.Nodes.Count > 0)
                    {
                        Node ret;
                        foreach (var node in n.Nodes)
                        {
                            ret = FindNode(node as Node, tagString);
                            if (ret != null)
                                return ret;
                            else
                                continue;
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        private void Subject9_junior_step_node(object sender, EventArgs e) => ShowChapter(new S9J_StepChapter());

        private void Subject9_Junior_evaluation_node_NodeClick(object sender, EventArgs e) => ShowChapter(new S9J_EvaluationChapter());

        private void S9J_Instrument_node_NodeClick(object sender, EventArgs e) => ShowChapter(new S9J_InstrumentChapter());

        private void S9J_Aid_node_NodeClick(object sender, EventArgs e) => ShowChapter(new S9J_AimChapter());

        private void S9I_AimChapter_node_click(object sender, EventArgs e) => ShowChapter(new S9I_AimChapter());

        private void S9I_Instrument_node_click(object sender, EventArgs e) => ShowChapter(new S9I_InstrumentChapter());

        private void S9I_CircuitStru_node_click(object sender, EventArgs e) => ShowChapter(new S9I_CircuitStructuresChapter());

        private void S9I_FailMode_node_click(object sender, EventArgs e) => ShowChapter(new S9I_FailModeChapter());

        private void S9I_FaultAna_node_click(object sender, EventArgs e) => ShowChapter(new S9I_FaultAnalysisChapter());

        private void S9I_Evaluation_node_click(object sender, EventArgs e) => ShowChapter(new S9I_EvaluationChapter());

        private void S9I_Repair_node_click(object sender, EventArgs e) => ShowChapter(new S9I_RepairChapter());

        private void S9S_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_AimChapter());

        private void S9S_InstrumentChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_InstrumentChapter());

        private void S9S_CircuitDtructuresChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_CircuitStructuresChapter());

        private void S9S_FailModeChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_FailModeChapter());

        private void S9S_StepChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_StepChapter());

        private void S9S_EvaluationChapter_click(object sender, EventArgs e) => ShowChapter(new S9S_EvaluationChapter());
        private void S9J_TheoryTestNodeClick(object sender, EventArgs e)
        {
            ExaminationBoard board = new ExaminationBoard();
            board.ShowExamination(ExaminationBuilder.GetExamination());
            panel1.Controls.Clear();
            panel1.Controls.Add(board);
            board.Show();
        }

        private void S8J_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S8J_AimChapter());

        private void S8J_InstrumentChapter_click(object sender, EventArgs e) => ShowChapter(new S8J_InstrumentChapter());

        private void S8J_StepChapter_click(object sender, EventArgs e) => ShowChapter(new S8J_StepChapter());

        private void S8J_EvaluationChapter_click(object sender, EventArgs e) => ShowChapter(new S8J_EvaluationChapter());

        private void S8I_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S8I_AimChapter());

        private void S8I_InstrumentChapter(object sender, EventArgs e) => ShowChapter(new S8I_InstrumentChapter());

        private void S8I_CircuitStructeursChapter(object sender, EventArgs e) => ShowChapter(new S8I_CircuitStructeursChapter());

        private void S8I_FailModeChapter(object sender, EventArgs e) => ShowChapter(new S8I_FailModeChapter());

        private void S8I_FaultAnalysisChapter_click(object sender, EventArgs e) => ShowChapter(new S8I_FaultAnalysisChapter());

        private void S8I_RepairChapter_click(object sender, EventArgs e) => ShowChapter(new S8I_RepairChapter());

        private void S8I_EvaluationChapter_click(object sender, EventArgs e) => ShowChapter(new S8I_EvaluationChapter());

        private void S8S_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_AimChapter());

        private void S8S_InstrumentChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_InstrumentChapter());

        private void S8S_CircuitStructuresChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_CircuitStructuresChapter());

        private void S8S_FailModeChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_FailModeChapter());

        private void S8S_StepChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_StepChapter());

        private void S8S_EvaluationChapter_click(object sender, EventArgs e) => ShowChapter(new S8S_EvaluationChapter());

        private void S7J_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S7J_AimChapter());

        private void S7J_InstrumentChapter_click(object sender, EventArgs e) => ShowChapter(new S7J_InstrumentChapter());

        private void S7J_StepChapter_click(object sender, EventArgs e) => ShowChapter(new S7J_StepChapter());

        private void S7J_EvaluationChapter_click(object sender, EventArgs e) => ShowChapter(new S7J_EvaluationChapter());

        private void S7I_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_AimChapter());

        private void S7I_InstrumentChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_InstrumentChapter());

        private void S7I_CircuitStructeursChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_CircuitStructeursChapter());

        private void S7I_FailModeChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_FailModeChapter());

        private void S7I_FaultAnalysisChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_FaultAnalysisChapter());

        private void S7I_RepairChapter_click(object sender, EventArgs e) => ShowChapter(new S7I_RepairChapter());

        private void S7I_EvaluationChapter__click(object sender, EventArgs e) => ShowChapter(new S7I_EvaluationChapter());

        private void S7S_AimChapter_click(object sender, EventArgs e) => ShowChapter(new S7S_AimChapter());

        private void DashBoard_btn_Click(object sender, EventArgs e)
        {
            DashBoard board = new DashBoard(device);
            board.Show();
        }
    }
}
