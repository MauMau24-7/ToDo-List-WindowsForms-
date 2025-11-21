using System.Text.Json;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class Form1 : Form
    {

        string path = Path.Combine(Application.UserAppDataPath, "checklist.json");

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox.CheckOnClick = true;

            if (File.Exists("checklist.json"))
            {
                string json = File.ReadAllText("checklist.json");
                List<CheckListItem> itemsFromFile = JsonSerializer.Deserialize<List<CheckListItem>>(json);

                foreach (var item in itemsFromFile)
                {
                    int index = checkBox.Items.Add(item.Text);
                    checkBox.SetItemChecked(index, item.Checked);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String item = textBox1.Text;
                checkBox.Items.Add(item);
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            checkBox.Items.Remove(checkBox.SelectedItem);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<CheckListItem> itemsToSave = new List<CheckListItem>();

            for (int i = 0; i < checkBox.Items.Count; i++)
            {
                itemsToSave.Add(new CheckListItem
                {
                    Text = checkBox.Items[i].ToString(),
                    Checked = checkBox.GetItemChecked(i)
                });
            }

            string json = JsonSerializer.Serialize(itemsToSave);
            File.WriteAllText(path, json);
        }

        class CheckListItem
        {
            public string Text { set; get; }
            public bool Checked {  set; get; }
        }
    }
}
