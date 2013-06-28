﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class KhoVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadComboBox(System.Windows.Forms.ComboBox cbo, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            cbo.DisplayMember = "Ten_kho";
            cbo.ValueMember = "ID_kho";
            cbo.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_KhoVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.Properties.DisplayMember = "Ten_kho";
            lookUpEdit.Properties.ValueMember = "ID_kho";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

		/// <summary>
		/// Load các kho trong tồn đầu kỳ
		/// </summary>
		/// <param name="lookUpEdit"></param>
		/// <param name="From"></param>
		/// <param name="To"></param>
		/// <param name="db"></param>
		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, DateTime From, DateTime To, QuanLyKhoDongLucEntities db = null)
		{
			if (db == null) db = new QuanLyKhoDongLucEntities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_TonDauKy.Where(t => t.Ky >= From && t.Ky <= To).Select(t => new { 
				Ten_kho = t.STO_KhoVatTu.Ten_kho,
				ID_kho = t.ID_kho,
				Dia_diem = t.STO_KhoVatTu.Dia_diem,
			}).Distinct().ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
			lookUpEdit.Properties.DisplayMember = "Ten_kho";
			lookUpEdit.Properties.ValueMember = "ID_kho";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
    }
}
