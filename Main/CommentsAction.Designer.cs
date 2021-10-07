
namespace Main
{
    partial class CommentsAction
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
            this.lbl_sbheadingTitle = new System.Windows.Forms.Label();
            this.rtx_comments = new System.Windows.Forms.RichTextBox();
            this.lbl_insertComments = new System.Windows.Forms.Label();
            this.lbl_enterAction = new System.Windows.Forms.Label();
            this.rtx_actionTaken = new System.Windows.Forms.RichTextBox();
            this.btn_takePic = new System.Windows.Forms.Button();
            this.btn_confirmInspection = new System.Windows.Forms.Button();
            this.btn_backSubHead = new System.Windows.Forms.Button();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.vsc_comments = new System.Windows.Forms.VScrollBar();
            this.vsc_actionTaken = new System.Windows.Forms.VScrollBar();
            this.pic_viewer = new System.Windows.Forms.PictureBox();
            this.lbl_picViewer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sbheadingTitle
            // 
            this.lbl_sbheadingTitle.AutoSize = true;
            this.lbl_sbheadingTitle.Location = new System.Drawing.Point(201, 12);
            this.lbl_sbheadingTitle.Name = "lbl_sbheadingTitle";
            this.lbl_sbheadingTitle.Size = new System.Drawing.Size(104, 20);
            this.lbl_sbheadingTitle.TabIndex = 0;
            this.lbl_sbheadingTitle.Text = "Sub-heading:\r\n";
            // 
            // rtx_comments
            // 
            this.rtx_comments.Location = new System.Drawing.Point(12, 140);
            this.rtx_comments.Name = "rtx_comments";
            this.rtx_comments.Size = new System.Drawing.Size(453, 116);
            this.rtx_comments.TabIndex = 1;
            this.rtx_comments.Text = "";
            // 
            // lbl_insertComments
            // 
            this.lbl_insertComments.AutoSize = true;
            this.lbl_insertComments.Location = new System.Drawing.Point(12, 117);
            this.lbl_insertComments.Name = "lbl_insertComments";
            this.lbl_insertComments.Size = new System.Drawing.Size(173, 20);
            this.lbl_insertComments.TabIndex = 2;
            this.lbl_insertComments.Text = "Insert comments below";
            // 
            // lbl_enterAction
            // 
            this.lbl_enterAction.AutoSize = true;
            this.lbl_enterAction.Location = new System.Drawing.Point(8, 270);
            this.lbl_enterAction.Name = "lbl_enterAction";
            this.lbl_enterAction.Size = new System.Drawing.Size(139, 20);
            this.lbl_enterAction.TabIndex = 3;
            this.lbl_enterAction.Text = "Enter action taken";
            // 
            // rtx_actionTaken
            // 
            this.rtx_actionTaken.Location = new System.Drawing.Point(12, 293);
            this.rtx_actionTaken.Name = "rtx_actionTaken";
            this.rtx_actionTaken.Size = new System.Drawing.Size(453, 119);
            this.rtx_actionTaken.TabIndex = 4;
            this.rtx_actionTaken.Text = "";
            // 
            // btn_takePic
            // 
            this.btn_takePic.Location = new System.Drawing.Point(16, 430);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(116, 52);
            this.btn_takePic.TabIndex = 5;
            this.btn_takePic.Text = "Take a picture";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // btn_confirmInspection
            // 
            this.btn_confirmInspection.Location = new System.Drawing.Point(349, 68);
            this.btn_confirmInspection.Name = "btn_confirmInspection";
            this.btn_confirmInspection.Size = new System.Drawing.Size(116, 52);
            this.btn_confirmInspection.TabIndex = 6;
            this.btn_confirmInspection.Text = "Confirm inspection";
            this.btn_confirmInspection.UseVisualStyleBackColor = true;
            this.btn_confirmInspection.Click += new System.EventHandler(this.btn_confirmInspection_Click);
            // 
            // btn_backSubHead
            // 
            this.btn_backSubHead.Location = new System.Drawing.Point(12, 604);
            this.btn_backSubHead.Name = "btn_backSubHead";
            this.btn_backSubHead.Size = new System.Drawing.Size(116, 52);
            this.btn_backSubHead.TabIndex = 7;
            this.btn_backSubHead.Text = "Exit no save";
            this.btn_backSubHead.UseVisualStyleBackColor = true;
            this.btn_backSubHead.Click += new System.EventHandler(this.btn_backSubHead_Click);
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.Location = new System.Drawing.Point(16, 516);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(116, 52);
            this.btn_deletePic.TabIndex = 8;
            this.btn_deletePic.Text = "Delete picture";
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.ImageLocation = "main.musk-logo.jpg";
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(183, 82);
            this.pic_logo.TabIndex = 9;
            this.pic_logo.TabStop = false;
            // 
            // vsc_comments
            // 
            this.vsc_comments.Location = new System.Drawing.Point(439, 140);
            this.vsc_comments.Name = "vsc_comments";
            this.vsc_comments.Size = new System.Drawing.Size(26, 116);
            this.vsc_comments.TabIndex = 10;
            this.vsc_comments.Visible = false;
            // 
            // vsc_actionTaken
            // 
            this.vsc_actionTaken.Location = new System.Drawing.Point(439, 293);
            this.vsc_actionTaken.Name = "vsc_actionTaken";
            this.vsc_actionTaken.Size = new System.Drawing.Size(26, 119);
            this.vsc_actionTaken.TabIndex = 11;
            this.vsc_actionTaken.Visible = false;
            // 
            // pic_viewer
            // 
            this.pic_viewer.Location = new System.Drawing.Point(200, 482);
            this.pic_viewer.Name = "pic_viewer";
            this.pic_viewer.Size = new System.Drawing.Size(239, 173);
            this.pic_viewer.TabIndex = 12;
            this.pic_viewer.TabStop = false;
            // 
            // lbl_picViewer
            // 
            this.lbl_picViewer.AutoSize = true;
            this.lbl_picViewer.Location = new System.Drawing.Point(206, 434);
            this.lbl_picViewer.Name = "lbl_picViewer";
            this.lbl_picViewer.Size = new System.Drawing.Size(173, 20);
            this.lbl_picViewer.TabIndex = 13;
            this.lbl_picViewer.Text = "Look into imageViewer ";
            // 
            // CommentsAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 678);
            this.Controls.Add(this.lbl_picViewer);
            this.Controls.Add(this.pic_viewer);
            this.Controls.Add(this.vsc_actionTaken);
            this.Controls.Add(this.vsc_comments);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_deletePic);
            this.Controls.Add(this.btn_backSubHead);
            this.Controls.Add(this.btn_confirmInspection);
            this.Controls.Add(this.btn_takePic);
            this.Controls.Add(this.rtx_actionTaken);
            this.Controls.Add(this.lbl_enterAction);
            this.Controls.Add(this.lbl_insertComments);
            this.Controls.Add(this.rtx_comments);
            this.Controls.Add(this.lbl_sbheadingTitle);
            this.Name = "CommentsAction";
            this.Text = "CommentsAction";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sbheadingTitle;
        private System.Windows.Forms.RichTextBox rtx_comments;
        private System.Windows.Forms.Label lbl_insertComments;
        private System.Windows.Forms.Label lbl_enterAction;
        private System.Windows.Forms.RichTextBox rtx_actionTaken;
        private System.Windows.Forms.Button btn_takePic;
        private System.Windows.Forms.Button btn_confirmInspection;
        private System.Windows.Forms.Button btn_backSubHead;
        private System.Windows.Forms.Button btn_deletePic;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.VScrollBar vsc_comments;
        private System.Windows.Forms.VScrollBar vsc_actionTaken;
        private System.Windows.Forms.PictureBox pic_viewer;
        private System.Windows.Forms.Label lbl_picViewer;
    }
}