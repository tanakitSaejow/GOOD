using Database.DataBase;
using GOOD.Models.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOOD.Models.Business.Home
{
    public class HomeMember : BaseMember
    {
        db_productEntities qDB = new db_productEntities();
        public List<tbMember> getProduct()
        {
            List<tbMember> Product = qDB.tbMembers.ToList();

            return Product;
        }
        public tbMember MemberInsert(DataMember DataInsert)
        {
            tbMember NewMember = new tbMember();
            NewMember.User_Name = DataInsert.User_Name;
            NewMember.User_Password = DataInsert.User_Password;
            NewMember.User_Email = DataInsert.User_Password;
            NewMember.User_Phone = DataInsert.User_Phone;
            NewMember.User_Gender = DataInsert.User_Gender;
            NewMember.User_isAdmin = DataInsert.User_isAdmin;
            qDB.tbMembers.Add(NewMember);
            qDB.SaveChanges();

            return NewMember;
        }
        public tbMember MemberDetail(int User_ID)
        {
            var DetailMember = qDB.tbMembers.Where(w => w.User_ID == User_ID).FirstOrDefault();

            return DetailMember;
        }
        public tbMember MemberEdit(DataMember DataInsert)
        {
            var EditMember = qDB.tbMembers.Where(w => w.User_ID == DataInsert.User_ID).FirstOrDefault();
            if (EditMember != null)
            {
                EditMember.User_Name = DataInsert.User_Name;
                EditMember.User_Password = DataInsert.User_Password;
                EditMember.User_Email = DataInsert.User_Email;
                EditMember.User_Phone = DataInsert.User_Phone;
                EditMember.User_Gender = DataInsert.User_Gender;
                EditMember.User_isAdmin = DataInsert.User_isAdmin;
                qDB.SaveChanges();
            }

            return EditMember;
        }
        public tbMember MemberDel(int User_ID)
        {
            var DelMember = qDB.tbMembers.Where(w => w.User_ID == User_ID).FirstOrDefault();
            qDB.tbMembers.Remove(DelMember);
            qDB.SaveChanges();

            return DelMember;
        }
    }
}