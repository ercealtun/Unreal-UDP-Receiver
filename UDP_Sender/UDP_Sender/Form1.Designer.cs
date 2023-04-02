namespace UDP_Sender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sendAllButton = new Button();
            dropDownList = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // sendAllButton
            // 
            sendAllButton.Location = new Point(555, 206);
            sendAllButton.Name = "sendAllButton";
            sendAllButton.Size = new Size(179, 26);
            sendAllButton.TabIndex = 0;
            sendAllButton.Text = "Send All";
            sendAllButton.UseVisualStyleBackColor = true;
            sendAllButton.Click += sendAllButton_Click;
            // 
            // dropDownList
            // 
            dropDownList.FormattingEnabled = true;
            dropDownList.Items.AddRange(new object[] { "string", "bool", "int", "float" });
            dropDownList.Location = new Point(533, 155);
            dropDownList.Name = "dropDownList";
            dropDownList.Size = new Size(221, 23);
            dropDownList.TabIndex = 1;
            dropDownList.SelectedIndexChanged += dropDownList_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(537, 96);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 3;
            label1.Text = "UDP Parameter Sender";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 431);
            Controls.Add(label1);
            Controls.Add(dropDownList);
            Controls.Add(sendAllButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendAllButton;
        private ComboBox dropDownList;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}