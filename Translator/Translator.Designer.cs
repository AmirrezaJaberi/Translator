namespace Translator
{
    partial class Translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.top_title = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.translate_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.speak = new System.Windows.Forms.Button();
            this.notification = new System.Windows.Forms.Label();
            this.output_select = new System.Windows.Forms.ComboBox();
            this.input_select = new System.Windows.Forms.ComboBox();
            this.swap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // top_title
            // 
            resources.ApplyResources(this.top_title, "top_title");
            this.top_title.ForeColor = System.Drawing.Color.White;
            this.top_title.Name = "top_title";
            this.top_title.Click += new System.EventHandler(this.top_title_Click);
            // 
            // input_label
            // 
            resources.ApplyResources(this.input_label, "input_label");
            this.input_label.ForeColor = System.Drawing.Color.White;
            this.input_label.Name = "input_label";
            // 
            // output_label
            // 
            resources.ApplyResources(this.output_label, "output_label");
            this.output_label.ForeColor = System.Drawing.Color.White;
            this.output_label.Name = "output_label";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.input, "input");
            this.input.ForeColor = System.Drawing.Color.White;
            this.input.Name = "input";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Black;
            this.output.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.output, "output");
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Name = "output";
            // 
            // translate_button
            // 
            resources.ApplyResources(this.translate_button, "translate_button");
            this.translate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translate_button.ForeColor = System.Drawing.Color.White;
            this.translate_button.Name = "translate_button";
            this.translate_button.UseVisualStyleBackColor = true;
            this.translate_button.Click += new System.EventHandler(this.translate_button_Click);
            // 
            // copy_button
            // 
            resources.ApplyResources(this.copy_button, "copy_button");
            this.copy_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_button.ForeColor = System.Drawing.Color.White;
            this.copy_button.Name = "copy_button";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // speak
            // 
            resources.ApplyResources(this.speak, "speak");
            this.speak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speak.ForeColor = System.Drawing.Color.White;
            this.speak.Name = "speak";
            this.speak.UseVisualStyleBackColor = true;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // notification
            // 
            resources.ApplyResources(this.notification, "notification");
            this.notification.BackColor = System.Drawing.Color.Black;
            this.notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification.ForeColor = System.Drawing.Color.White;
            this.notification.Name = "notification";
            // 
            // output_select
            // 
            this.output_select.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.output_select, "output_select");
            this.output_select.ForeColor = System.Drawing.Color.White;
            this.output_select.FormattingEnabled = true;
            this.output_select.Name = "output_select";
            // 
            // input_select
            // 
            this.input_select.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.input_select, "input_select");
            this.input_select.ForeColor = System.Drawing.Color.White;
            this.input_select.FormattingEnabled = true;
            this.input_select.Name = "input_select";
            // 
            // swap
            // 
            resources.ApplyResources(this.swap, "swap");
            this.swap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swap.ForeColor = System.Drawing.Color.White;
            this.swap.Name = "swap";
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // Translator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.swap);
            this.Controls.Add(this.input_select);
            this.Controls.Add(this.output_select);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.speak);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.translate_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.top_title);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "Translator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label top_title;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button translate_button;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button speak;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.ComboBox output_select;
        private System.Windows.Forms.ComboBox input_select;
        private System.Windows.Forms.Button swap;
    }
}

