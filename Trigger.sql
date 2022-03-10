Create Trigger AddBlogInRaytingTable on Blogs After insert as declare @ID int
select @ID=BlogID from inserted insert into BlogRaytings(BlogID,BlogTotalScore,BlogRaytingCount)
values (@ID,0,0)