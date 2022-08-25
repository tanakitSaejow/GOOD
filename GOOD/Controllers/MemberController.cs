using GOOD.Models.Business.Base;
using GOOD.Models.Business.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOOD.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ShowMember()
        {
            return View();
        }
        #region Insert
        [HttpPost]
        public ActionResult InsertMember(BaseMember.DataMember DataMemberInput)
        {
            var NewInsert = DataMemberInput;
            HomeMember Member = new HomeMember();
            var NewMember = Member.MemberInsert(NewInsert);
            return Json(NewMember);
        }
        #endregion

        #region Delete
        [HttpPost]
        public ActionResult DelMember(BaseMember.DataMember MemberId)
        {
            var IDMember = MemberId.User_ID;
            HomeMember Member = new HomeMember();
            var ID = Member.MemberDel(IDMember);

            return Json(ID);
        }
        #endregion

        #region Edit
        [HttpPost]
        public ActionResult EditMember(BaseMember.DataMember DataMemberEdit)
        {
            var NewMemberEdit = DataMemberEdit;
            HomeMember Member = new HomeMember();
            var NewEdit = Member.MemberEdit(NewMemberEdit);
            return Json(NewEdit);
        }
        #endregion

        #region Detail
        [HttpPost]
        public ActionResult DetailMember(BaseMember.DataMember MemberId)
        {
            var IDMember = MemberId.User_ID;
            HomeMember Member = new HomeMember();
            var MemberDetail = Member.MemberDetail(IDMember);
            return Json(MemberDetail);
        }
        #endregion
    }
}