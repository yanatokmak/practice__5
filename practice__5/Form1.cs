using practice__5;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace practice__5
{
    public partial class Form1 : Form
    {
        private List<ComputerTechnique> techniques = new List<ComputerTechnique>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            UpdateFieldVisibility();



            comboBoxObjectType.SelectedIndexChanged += ComboBoxObjectType_SelectedIndexChanged;
            buttonAdd.Click += ButtonAdd_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonEdit.Click += ButtonEdit_Click;
        }
        private void ComboBoxObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFieldVisibility();
        }
        private void InitializeComboBox()
        {
            
            comboBoxObjectType.SelectedIndex = 0;

        }
           
            private void UpdateFieldVisibility()
        {
            string selectedType = comboBoxObjectType.SelectedItem.ToString();

            
            labelManufacturer.Visible = true;
            textBoxManufacturer.Visible = true;
            labelModel.Visible = true;
            textBoxModel.Visible = true;
            labelPrice.Visible = true;
            textBoxPrice.Visible = true;

            
            labelWeight.Visible = selectedType == "Клавиатура";
            textBoxWeight.Visible = selectedType == "Клавиатура";
            labelBackLighting.Visible = selectedType == "Клавиатура";
            textBoxBackLighting.Visible = selectedType == "Клавиатура";

            
            labelRefreshRate.Visible = selectedType == "Монитор";
            textBoxRefreshRate.Visible = selectedType == "Монитор";
            labelDiagonal.Visible = selectedType == "Монитор";
            textBoxDiagonal.Visible = selectedType == "Монитор";
        }

        
        private void UpdateListBox()
        {
            listBoxObjects.Items.Clear();
            foreach (var technique in techniques)
            {
                listBoxObjects.Items.Add(technique.PrintInfo());
            }
        }

        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string manufacturer = textBoxManufacturer.Text;
            string model = textBoxModel.Text;

            if (!int.TryParse(textBoxPrice.Text, out int price))
            {
                MessageBox.Show("Введите корректную цену.");
                return;
            }

            string selectedType = comboBoxObjectType.SelectedItem.ToString();
            switch (selectedType)
            {
                case "Компьютерная техника":
                    techniques.Add(new ComputerTechnique(manufacturer, model, price));
                    break;

                case "Клавиатура":
                    if (!int.TryParse(textBoxWeight.Text, out int weight))
                    {
                        MessageBox.Show("Введите корректный вес.");
                        return;
                    }
                    string backLighting = textBoxBackLighting.Text;
                    techniques.Add(new Keyboard(manufacturer, model, price, weight, backLighting));
                    break;

                case "Монитор":
                    if (!int.TryParse(textBoxRefreshRate.Text, out int refreshRate))
                    {
                        MessageBox.Show("Введите корректную частоту обновления.");
                        return;
                    }
                    if (!double.TryParse(textBoxDiagonal.Text, out double diagonal))
                    {
                        MessageBox.Show("Введите корректную диагональ.");
                        return;
                    }
                    techniques.Add(new Screen(manufacturer, model, price, refreshRate, diagonal));
                    break;

                default:
                    MessageBox.Show("Неизвестный тип объекта.");
                    return;
            }

            
            ClearFields();
            UpdateListBox();
        }

        
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите объект для удаления.");
                return;
            }

            techniques.RemoveAt(listBoxObjects.SelectedIndex);
            UpdateListBox();
        }

        
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите объект для редактирования.");
                return;
            }

            int selectedIndex = listBoxObjects.SelectedIndex;
            var selectedTechnique = techniques[selectedIndex];

            
            textBoxManufacturer.Text = selectedTechnique.Manufacturer;
            textBoxModel.Text = selectedTechnique.Model;
            textBoxPrice.Text = selectedTechnique.Price.ToString();

            if (selectedTechnique is Keyboard keyboard)
            {
                textBoxWeight.Text = keyboard.Weight.ToString();
                textBoxBackLighting.Text = keyboard.Backlighting;
                comboBoxObjectType.SelectedItem = "Клавиатура";
            }
            else if (selectedTechnique is Screen screen)
            {
                textBoxRefreshRate.Text = screen.RefreshRate.ToString();
                textBoxDiagonal.Text = screen.Diagonal.ToString();
                comboBoxObjectType.SelectedItem = "Монитор";
            }
            else
            {
                comboBoxObjectType.SelectedItem = "Компьютерная техника";
            }

            
            techniques.RemoveAt(selectedIndex);
            UpdateListBox();
        }

        
        private void ClearFields()
        {
            textBoxManufacturer.Clear();
            textBoxModel.Clear();
            textBoxPrice.Clear();
            textBoxWeight.Clear();
            textBoxBackLighting.Clear();
            textBoxRefreshRate.Clear();
            textBoxDiagonal.Clear();
        }
    }
}
