using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_2
{
    public partial class Form1 : Form
    {
        List<InputResult> events = new List<InputResult>();

        public Form1()
        {
            InitializeComponent();

            // настраиваем корневое событие
            cbRootType.SelectedIndex = 0; // AND
            events.Add(new InputResult(TypeElem.And)
            {
                Name = tbRootName.Text,
                Parent = null
            });
            SyncTree();
        }

        // удаление
        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                RemoveRecursive(treeView.SelectedNode.Tag as InputResult);
                
                SyncTree();
                // treeView.Nodes.Remove(treeView.SelectedNode);
            }
        }

        private void RemoveRecursive(InputResult forDelete)
        {
            events.Remove(forDelete);
            var childs = events.FindAll((ev) => ev.Parent?.Name == forDelete.Name).ToList();
            for(int i = 0; i < childs.Count; i++)
            {
                RemoveRecursive(childs[i]);
            }
        }

        // добавление
        private void button1_Click(object sender, EventArgs e)
        {
            var selected = treeView.SelectedNode ?? treeView.Nodes[0];

            TypeElem type = rbProb.Checked
                ? TypeElem.Init
                : rbAnd.Checked ? TypeElem.And : TypeElem.Or;

            var form = new InputForm(type, selected.Tag as InputResult);
            form.ShowDialog();

            events.Add(form.Result);
            SyncTree();
        }

        private void SyncTree()
        {
            treeView.Nodes.Clear();
            events.ForEach(e =>
            {
                string prefix = "";
                string postfix = "";
                switch (e.Type)
                {
                    case TypeElem.And:
                        prefix = "[И]";
                        break;
                    case TypeElem.Or:
                        prefix = "[ИЛИ]";
                        break;
                    case TypeElem.Init:
                        postfix = $" (x{e.Id}, p = {e.Probably})";
                        break;
                }

                var node = new TreeNode()
                {
                    Name = e.Name,
                    Text = $"{prefix} {e.Name}{postfix}",
                    Tag = e
                };

                TreeNode parent = null;
                if (e.Parent != null)
                    parent = treeView.Nodes.Find(e.Parent.Name, true).First();

                if (parent != null)
                    parent.Nodes.Add(node);
                else
                    treeView.Nodes.Add(node);
            });

            treeView.ExpandAll();
        }

        private void cbRootType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (events.Count > 0)
            {
                events[0].Type = cbRootType.SelectedIndex == 0 ? TypeElem.And : TypeElem.Or;
                SyncTree();
            }
        }

        private void tbRootName_TextChanged(object sender, EventArgs e)
        {
            if (events.Count > 0)
            {
                events[0].Name = tbRootName.Text;
                SyncTree();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                // ФАЛ
                var table = GetFAL(treeView.Nodes[0]);

                var diz = new List<string>();
                for (int i = 0; i < table.Count; i++)
                {
                    var kon = new List<string>();
                    for (int j = 0; j < table[i].Count; j++)
                    {
                        kon.Add($"x{table[i][j].Id}");
                    }
                    diz.Add($"({String.Join("/\\", kon)})");
                }
                tbFAL.Text = String.Join("U" ,diz);
            }
        }

        private List<List<InputResult>> GetFAL(TreeNode node)
        {
            var res = node.Tag as InputResult;
            var type = res.Type;
            var list = new List<List<InputResult>>();

            if (type == TypeElem.Init)
            {
                var one = new List<InputResult>();
                one.Add(res);
                list.Add(one);
            } 
            else 
            {
                var count = node.Nodes.Count;
                
                if (type == TypeElem.And)
                {
                    var temp = new List<List<List<InputResult>>>();

                    for (int i = 0; i < count; i++)
                    {
                        temp.Add(GetFAL(node.Nodes[i]));
                    }

                    var result = new List<List<InputResult>>();
                    DecartMul(temp, new List<InputResult>(), 0, result);

                    list.AddRange(result);

                } 
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        list.AddRange(GetFAL(node.Nodes[i]));
                    }
                }
            }

            return list;
        }

        private void DecartMul(List<List<List<InputResult>>> table, List<InputResult> currentSet, int column, List<List<InputResult>> result)
        {
            if (table.Count == column)
            {
                result.Add(currentSet);
                return;
            } 

            var items = table[column];
            for (int i = 0; i < items.Count; i++)
            {
                var list = new List<InputResult>(currentSet);
                list.AddRange(items[i]);
                DecartMul(table, list, column + 1, result);
            }
        }

        private bool Check()
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Type != TypeElem.Init)
                {
                    var firstChild = events.Find((ev) => ev.Parent?.Name == events[i].Name);
                    if (firstChild == null)
                    {
                        MessageBox.Show($"У промежуточного события \"{events[i].Name}\" нет дочерних");
                        return false;
                    }
                }
            }

            return true;
        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(ofd.FileName))
                {
                    events.Clear();
                    var count = Convert.ToInt32(sr.ReadLine());

                    TypeElem type;
                    string typeText, name, idText, parentText, probablyText;
                    var parentNames = new List<string>();
                    for (int i = 0;i < count; i++)
                    {
                        typeText = sr.ReadLine();
                        name = sr.ReadLine();
                        idText = sr.ReadLine();
                        parentText = sr.ReadLine();
                        probablyText = sr.ReadLine();


                        switch (typeText)
                        {
                            case "And":
                                type = TypeElem.And;
                                break;
                            case "Or":
                                type = TypeElem.Or;
                                break;
                            default:
                                type = TypeElem.Init;
                                break;
                        }

                        parentNames.Add(parentText);

                        var res = new InputResult(type) { Name = name };

                        if (type == TypeElem.Init)
                        {
                            res.Probably = Convert.ToDouble(probablyText);
                            res.Id = Convert.ToInt32(idText);
                        }

                        events.Add(res);
                    }

                    for (int i = 0; i < events.Count; i++)
                    {
                        events[i].Parent = string.IsNullOrEmpty(parentNames[i])
                                    ? null
                                    : events.Find(x => x.Name == parentNames[i]);
                    }
                }

                SyncTree();
            }
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(events.Count);

                    string typeText;
                    events.ForEach(ev =>
                    {
                        switch (ev.Type)
                        {
                            case TypeElem.And:
                                typeText = "And";
                                break;
                            case TypeElem.Or:
                                typeText = "Or";
                                break;
                            default:
                                typeText = "Init";
                                break;
                        }

                        sw.WriteLine(typeText);
                        sw.WriteLine(ev.Name);
                        sw.WriteLine(ev.Id);
                        sw.WriteLine(ev.Parent?.Name ?? "");
                        sw.WriteLine(ev.Probably);
                    });
                }
            }
        }
    }
}
