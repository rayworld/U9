using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using U9.Areas.Admin.Models;
using U9.Models;

namespace U9.Areas.Admin.Controllers
{
    public class UserEntitiesController : ApiController
    {
        private U9Context db = new U9Context();

        [HttpGet]
        // GET: api/UserEntities
        public ResultEntity<UserEntity> GetUserEntities(int pageIndex, int pageSize)
        {
            //return db.UserEntities;

            IQueryable<UserEntity> queryUsers = BuildTestData().AsQueryable();

            IQueryable<UserEntity> pagedUser = queryUsers.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            ResultEntity<UserEntity> resultEntity = new ResultEntity<UserEntity>
            {
                Code = 0,
                Msg = "",
                Count = queryUsers.Count<UserEntity>(),
                Data = pagedUser.ToList()
            };
            return resultEntity;
        }

        #region 测试数据
        private List<UserEntity> BuildTestData()
        {
            List<UserEntity> users = new List<UserEntity>
            {
                new UserEntity() { Id = 10000, UserName = "user-0", Sex = "女", City = "城市-0", Sign = "签名-0", Experience = 255, Logins = 24, Wealth = 82830700, Classify = "作家",Score = 57 },
                new UserEntity() { Id = 10001, UserName = "user-1", Sex = "男", City = "城市-1", Sign = "签名-1", Experience = 884, Logins = 58, Wealth = 64928690, Classify = "词人", Score = 27 },
                new UserEntity() { Id = 10002, UserName = "user-2", Sex = "女", City = "城市-2", Sign = "签名-2", Experience = 650, Logins = 77, Wealth = 6298078, Classify = "酱油", Score = 31 },
                new UserEntity() { Id = 10003, UserName = "user-3", Sex = "女", City = "城市-3", Sign = "签名-3", Experience = 362, Logins = 157, Wealth = 37117017, Classify = "诗人", Score = 68 },
                new UserEntity() { Id = 10004, UserName = "user-4", Sex = "男", City = "城市-4", Sign = "签名-4", Experience = 807, Logins = 51, Wealth = 76263262, Classify = "作家", Score = 6 },
                new UserEntity() { Id = 10005, UserName = "user-5", Sex = "女", City = "城市-5", Sign = "签名-5", Experience = 173, Logins = 68, Wealth = 60344147, Classify = "作家", Score = 87 },
                new UserEntity() { Id = 10006, UserName = "user-6", Sex = "女", City = "城市-6", Sign = "签名-6", Experience = 982, Logins = 37, Wealth = 57768166, Classify = "作家", Score = 34},
                new UserEntity() { Id = 10007, UserName = "user-7", Sex = "男", City = "城市-7", Sign = "签名-7", Experience = 727, Logins = 150, Wealth = 82030578, Classify = "作家", Score = 28},
                new UserEntity() { Id = 10008, UserName = "user-8", Sex = "男", City = "城市-8", Sign = "签名-8", Experience = 951, Logins = 133, Wealth = 16503371, Classify = "词人", Score = 14},
                new UserEntity() { Id = 10009, UserName = "user-9", Sex = "女", City = "城市-9", Sign = "签名-9", Experience = 484, Logins = 25, Wealth = 86801934, Classify = "词人", Score = 75},
                new UserEntity() { Id = 10010, UserName = "user-10", Sex = "女", City = "城市-10", Sign = "签名-10", Experience = 1016, Logins = 182, Wealth = 71294671, Classify = "诗人", Score = 34},
                new UserEntity() { Id = 10011, UserName = "user-11", Sex = "女", City = "城市-11", Sign = "签名-11", Experience = 492, Logins = 107, Wealth = 8062783, Classify = "诗人", Score = 6},
                new UserEntity() { Id = 10012, UserName = "user-12", Sex = "女", City = "城市-12", Sign = "签名-12", Experience = 106, Logins = 176, Wealth = 42622704, Classify = "词人", Score = 54},
                new UserEntity() { Id = 10013, UserName = "user-13", Sex = "男", City = "城市-13", Sign = "签名-13", Experience = 1047, Logins = 94, Wealth = 59508583, Classify = "诗人", Score = 63},
                new UserEntity() { Id = 10014, UserName = "user-14", Sex = "男", City = "城市-14", Sign = "签名-14", Experience = 873, Logins = 116, Wealth = 72549912, Classify = "词人", Score = 8},
                new UserEntity() { Id = 10015, UserName = "user-15", Sex = "女", City = "城市-15", Sign = "签名-15", Experience = 1068, Logins = 27, Wealth = 52737025, Classify = "作家", Score = 28 },
                new UserEntity() { Id = 10016, UserName = "user-16", Sex = "女", City = "城市-16", Sign = "签名-16", Experience = 862, Logins = 168, Wealth = 37069775, Classify = "酱油", Score = 86},
                new UserEntity() { Id = 10017, UserName = "user-17", Sex = "女", City = "城市-17", Sign = "签名-17", Experience = 1060, Logins = 187, Wealth = 66099525, Classify = "作家", Score = 69},
                new UserEntity() { Id = 10018, UserName = "user-18", Sex = "女", City = "城市-18", Sign = "签名-18", Experience = 866, Logins = 88, Wealth = 81722326, Classify = "词人", Score = 74},
                new UserEntity() { Id = 10019, UserName = "user-19", Sex = "女", City = "城市-19", Sign = "签名-19", Experience = 682, Logins = 106, Wealth = 68647362, Classify = "词人", Score = 51},
                new UserEntity() { Id = 10020, UserName = "user-20", Sex = "男", City = "城市-20", Sign = "签名-20", Experience = 770, Logins = 24, Wealth = 92420248, Classify = "诗人", Score = 87},
                new UserEntity() { Id = 10021, UserName = "user-21", Sex = "男", City = "城市-21", Sign = "签名-21", Experience = 184, Logins = 131, Wealth = 71566045, Classify = "词人", Score = 99 },
                new UserEntity() { Id = 10022, UserName = "user-22", Sex = "男", City = "城市-22", Sign = "签名-22", Experience = 739, Logins = 152, Wealth = 60907929, Classify = "作家", Score = 18 },
                new UserEntity() { Id = 10023, UserName = "user-23", Sex = "女", City = "城市-23", Sign = "签名-23", Experience = 127, Logins = 82, Wealth = 14765943, Classify = "作家", Score = 30},
                new UserEntity() { Id = 10024, UserName = "user-24", Sex = "女", City = "城市-24", Sign = "签名-24", Experience = 212, Logins = 133, Wealth = 59011052, Classify = "词人", Score = 76},
                new UserEntity() { Id = 10025, UserName = "user-25", Sex = "女", City = "城市-25", Sign = "签名-25", Experience = 938, Logins = 182, Wealth = 91183097, Classify = "作家", Score = 69 },
                new UserEntity() { Id = 10026, UserName = "user-26", Sex = "男", City = "城市-26", Sign = "签名-26", Experience = 978, Logins = 7, Wealth = 48008413, Classify = "作家", Score = 65},
                new UserEntity() { Id = 10027, UserName = "user-27", Sex = "女", City = "城市-27", Sign = "签名-27", Experience = 371,  Logins = 44, Wealth = 64419691,  Classify = "诗人",  Score = 60 },
                new UserEntity() { Id = 10028, UserName = "user-28", Sex = "女", City = "城市-28", Sign = "签名-28", Experience = 977,  Logins = 21, Wealth = 75935022,  Classify = "作家",  Score = 37 },
                new UserEntity() { Id = 10029, UserName = "user-29", Sex = "男", City = "城市-29", Sign = "签名-29", Experience = 647,  Logins = 107, Wealth = 97450636,  Classify = "酱油",  Score = 27}
            };
            return users;
        }

        #endregion


        #region 试点范围发
        // GET: api/UserEntities/5
        [ResponseType(typeof(UserEntity))]
        public IHttpActionResult GetUserEntity(int id)
        {
            UserEntity userEntity = db.UserEntities.Find(id);
            if (userEntity == null)
            {
                return NotFound();
            }

            return Ok(userEntity);
        }

        // PUT: api/UserEntities/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserEntity(int id, UserEntity userEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userEntity.Id)
            {
                return BadRequest();
            }

            db.Entry(userEntity).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UserEntities
        [ResponseType(typeof(UserEntity))]
        public IHttpActionResult PostUserEntity(UserEntity userEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserEntities.Add(userEntity);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = userEntity.Id }, userEntity);
        }

        // DELETE: api/UserEntities/5
        [ResponseType(typeof(UserEntity))]
        public IHttpActionResult DeleteUserEntity(int id)
        {
            UserEntity userEntity = db.UserEntities.Find(id);
            if (userEntity == null)
            {
                return NotFound();
            }

            db.UserEntities.Remove(userEntity);
            db.SaveChanges();

            return Ok(userEntity);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserEntityExists(int id)
        {
            return db.UserEntities.Count(e => e.Id == id) > 0;
        }
        #endregion

    }
}