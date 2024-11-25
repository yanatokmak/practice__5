namespace practice__5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxObjectType = new System.Windows.Forms.ComboBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxBackLighting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBackLighting = new System.Windows.Forms.Label();
            this.labelRefreshRate = new System.Windows.Forms.Label();
            this.textBoxRefreshRate = new System.Windows.Forms.TextBox();
            this.textBoxDiagonal = new System.Windows.Forms.TextBox();
            this.labelDiagonal = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxObjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxObjectType
            // 
            this.comboBoxObjectType.FormattingEnabled = true;
            this.comboBoxObjectType.Items.AddRange(new object[] {
            "Компьютерная техника",
            "Клавиатура",
            "Монитор"});
            this.comboBoxObjectType.Location = new System.Drawing.Point(153, 12);
            this.comboBoxObjectType.Name = "comboBoxObjectType";
            this.comboBoxObjectType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObjectType.TabIndex = 1;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(153, 64);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(121, 20);
            this.textBoxManufacturer.TabIndex = 2;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(153, 90);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(121, 20);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(153, 116);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(153, 142);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxWeight.TabIndex = 5;
            // 
            // textBoxBackLighting
            // 
            this.textBoxBackLighting.Location = new System.Drawing.Point(153, 168);
            this.textBoxBackLighting.Name = "textBoxBackLighting";
            this.textBoxBackLighting.Size = new System.Drawing.Size(121, 20);
            this.textBoxBackLighting.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип объекта:";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(29, 64);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(89, 13);
            this.labelManufacturer.TabIndex = 11;
            this.labelManufacturer.Text = "Производитель:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(29, 90);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 12;
            this.labelModel.Text = "Модель:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(29, 116);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Цена:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(29, 142);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(29, 13);
            this.labelWeight.TabIndex = 14;
            this.labelWeight.Text = "Вес:";
            // 
            // labelBackLighting
            // 
            this.labelBackLighting.AutoSize = true;
            this.labelBackLighting.Location = new System.Drawing.Point(29, 168);
            this.labelBackLighting.Name = "labelBackLighting";
            this.labelBackLighting.Size = new System.Drawing.Size(65, 13);
            this.labelBackLighting.TabIndex = 15;
            this.labelBackLighting.Text = "Подсветка:";
            // 
            // labelRefreshRate
            // 
            this.labelRefreshRate.AutoSize = true;
            this.labelRefreshRate.Location = new System.Drawing.Point(29, 142);
            this.labelRefreshRate.Name = "labelRefreshRate";
            this.labelRefreshRate.Size = new System.Drawing.Size(115, 13);
            this.labelRefreshRate.TabIndex = 16;
            this.labelRefreshRate.Text = "Частота обновления:";
            // 
            // textBoxRefreshRate
            // 
            this.textBoxRefreshRate.Location = new System.Drawing.Point(153, 142);
            this.textBoxRefreshRate.Name = "textBoxRefreshRate";
            this.textBoxRefreshRate.Size = new System.Drawing.Size(121, 20);
            this.textBoxRefreshRate.TabIndex = 17;
            // 
            // textBoxDiagonal
            // 
            this.textBoxDiagonal.Location = new System.Drawing.Point(153, 168);
            this.textBoxDiagonal.Name = "textBoxDiagonal";
            this.textBoxDiagonal.Size = new System.Drawing.Size(121, 20);
            this.textBoxDiagonal.TabIndex = 18;
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.Location = new System.Drawing.Point(30, 168);
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(66, 13);
            this.labelDiagonal.TabIndex = 19;
            this.labelDiagonal.Text = "Диагональ:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(113, 223);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(194, 223);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // listBoxObjects
            // 
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.Location = new System.Drawing.Point(280, 15);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.Size = new System.Drawing.Size(578, 199);
            this.listBoxObjects.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.listBoxObjects);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDiagonal);
            this.Controls.Add(this.textBoxDiagonal);
            this.Controls.Add(this.textBoxRefreshRate);
            this.Controls.Add(this.labelRefreshRate);
            this.Controls.Add(this.labelBackLighting);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBackLighting);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.comboBoxObjectType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxObjectType;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBackLighting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBackLighting;
        private System.Windows.Forms.Label labelRefreshRate;
        private System.Windows.Forms.TextBox textBoxRefreshRate;
        private System.Windows.Forms.TextBox textBoxDiagonal;
        private System.Windows.Forms.Label labelDiagonal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxObjects;
    }
}