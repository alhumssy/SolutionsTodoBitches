namespace WebForEver.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        iduserpor = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        CourseId = c.Int(),
                        isregister = c.Boolean(),
                        phonenum = c.Int(),
                        Intrested = c.Boolean(),
                        PostId = c.Int(),
                        ApplicationUserId = c.String(),
                        Course_IdCourse = c.Int(),
                        PostFeed_id = c.Int(),
                    })
                .PrimaryKey(t => t.iduserpor)
                .ForeignKey("dbo.Course", t => t.Course_IdCourse)
                .ForeignKey("dbo.PostFeed", t => t.PostFeed_id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Course_IdCourse)
                .Index(t => t.PostFeed_id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        IdCourse = c.Int(nullable: false, identity: true),
                        CoursName = c.String(maxLength: 50),
                        shortDescription = c.String(maxLength: 50),
                        dateExpected = c.DateTime(),
                        hoursNO = c.Int(),
                        feature = c.Boolean(),
                        imgsrc = c.String(maxLength: 50),
                        vediosrc = c.String(maxLength: 50),
                        idsubcategory = c.Int(),
                    })
                .PrimaryKey(t => t.IdCourse)
                .ForeignKey("dbo.Subcategory", t => t.idsubcategory)
                .Index(t => t.idsubcategory);
            
            CreateTable(
                "dbo.CourseDetails",
                c => new
                    {
                        idCoursedetails = c.Int(nullable: false, identity: true),
                        idcourses = c.Int(),
                        description = c.String(maxLength: 200),
                        Course_IdCourse = c.Int(),
                    })
                .PrimaryKey(t => t.idCoursedetails)
                .ForeignKey("dbo.Course", t => t.Course_IdCourse)
                .Index(t => t.Course_IdCourse);
            
            CreateTable(
                "dbo.Subcategory",
                c => new
                    {
                        Idsubcategory = c.Int(nullable: false, identity: true),
                        subcategoryname = c.String(maxLength: 50),
                        idcategorytype = c.Int(),
                        subdescription = c.String(maxLength: 50),
                        CategoryType_idctype = c.Int(),
                    })
                .PrimaryKey(t => t.Idsubcategory)
                .ForeignKey("dbo.CategoryType", t => t.CategoryType_idctype)
                .Index(t => t.CategoryType_idctype);
            
            CreateTable(
                "dbo.CategoryType",
                c => new
                    {
                        idctype = c.Int(nullable: false, identity: true),
                        categoryname = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idctype);
            
            CreateTable(
                "dbo.VideoCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50),
                        IdCourse = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Course", t => t.IdCourse)
                .Index(t => t.IdCourse);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        VideoName = c.String(maxLength: 50),
                        videoSrc = c.String(),
                        IdVideoCategory = c.Int(),
                        VideoCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.VideoCategory", t => t.VideoCategory_Id)
                .Index(t => t.VideoCategory_Id);
            
            CreateTable(
                "dbo.PostFeed",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PostSubject = c.String(maxLength: 50),
                        PostContent = c.String(),
                        postImg = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Hometown = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfile", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserProfile", "PostFeed_id", "dbo.PostFeed");
            DropForeignKey("dbo.Video", "VideoCategory_Id", "dbo.VideoCategory");
            DropForeignKey("dbo.VideoCategory", "IdCourse", "dbo.Course");
            DropForeignKey("dbo.UserProfile", "Course_IdCourse", "dbo.Course");
            DropForeignKey("dbo.Course", "idsubcategory", "dbo.Subcategory");
            DropForeignKey("dbo.Subcategory", "CategoryType_idctype", "dbo.CategoryType");
            DropForeignKey("dbo.CourseDetails", "Course_IdCourse", "dbo.Course");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Video", new[] { "VideoCategory_Id" });
            DropIndex("dbo.VideoCategory", new[] { "IdCourse" });
            DropIndex("dbo.Subcategory", new[] { "CategoryType_idctype" });
            DropIndex("dbo.CourseDetails", new[] { "Course_IdCourse" });
            DropIndex("dbo.Course", new[] { "idsubcategory" });
            DropIndex("dbo.UserProfile", new[] { "PostFeed_id" });
            DropIndex("dbo.UserProfile", new[] { "Course_IdCourse" });
            DropIndex("dbo.UserProfile", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.PostFeed");
            DropTable("dbo.Video");
            DropTable("dbo.VideoCategory");
            DropTable("dbo.CategoryType");
            DropTable("dbo.Subcategory");
            DropTable("dbo.CourseDetails");
            DropTable("dbo.Course");
            DropTable("dbo.UserProfile");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
