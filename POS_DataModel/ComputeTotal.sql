SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER TRIGGER[dbo].[ComputeTotal]
	ON [dbo].[Cart]
	AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update Cart set Total=(Price*Quantity)-Discount
	update Cart set Status="Cancelled" where Quantity<=0

    -- Insert statements for trigger here

END