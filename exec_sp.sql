USE [Report]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[monthReport_0007_TechnReport_BODY]
		@dt = '2018.01.01',
		@year = 0

SELECT	@return_value as 'Return Value'

GO
