create trigger AddScoreInComment on Comments after insert as 
Declare @ID int 
Declare @Score int
Declare @RaytingCount int
Select @ID=BlogID, @Score=BlogScore from inserted
Update BlogRaytings set BlogTotalScore=BlogTotalScore+@Score,BlogRaytingCount+=1 where BlogID=@ID