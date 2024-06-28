namespace CRUD_HAPPY_PET.Views
{
    partial class PetView
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
            label1 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            txtPetType = new TextBox();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(769, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 23);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 399);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 371);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Location = new Point(8, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(683, 299);
            dataGridView1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(697, 120);
            button4.Name = "button4";
            button4.Size = new Size(87, 23);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(697, 91);
            button3.Name = "button3";
            button3.Size = new Size(87, 23);
            button3.TabIndex = 4;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(697, 62);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 3;
            button2.Text = "Add new";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(616, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(8, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(602, 23);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 19);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Search pet:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(txtPetType);
            tabPage2.Controls.Add(txtPetName);
            tabPage2.Controls.Add(txtPetId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 371);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pet Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 139);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 9;
            label6.Text = "Pet colour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 90);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Pet type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 90);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Pet name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 41);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Pet ID:";
            // 
            // button6
            // 
            button6.Location = new Point(157, 191);
            button6.Name = "button6";
            button6.Size = new Size(100, 30);
            button6.TabIndex = 5;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(42, 191);
            button5.Name = "button5";
            button5.Size = new Size(100, 30);
            button5.TabIndex = 4;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(42, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 23);
            textBox5.TabIndex = 3;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(157, 108);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 2;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(42, 108);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 1;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(42, 59);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(100, 23);
            txtPetId.TabIndex = 0;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            Load += PetView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button6;
        private Button button5;
        private TextBox textBox5;
        private TextBox txtPetType;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private DataGridView dataGridView1;
        private Button btnClose;
    }
}