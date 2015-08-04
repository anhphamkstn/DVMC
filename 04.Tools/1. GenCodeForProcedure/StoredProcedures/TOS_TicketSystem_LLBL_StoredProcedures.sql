CREATE PROCEDURE [dbo].[pr_V_DM_BLACK_LIST_Insert]
	@SO_DIEN_THOAI nvarchar(15),
	@ID_NGUOI_ADD numeric(18, 0),
	@ID_NGUOI_REMOVE numeric(18, 0),
	@NGAY_ADD datetime,
	@NGAY_REMOVE datetime,
	@ADD_YN nvarchar(1),
	@HO_TEN_CHU_DIEN_THOAI nvarchar(250),
	@GHI_CHU_LY_DO nvarchar(250),
	@ACCOUNT_NGUOI_ADD nvarchar(35),
	@TEN_NGUOI_ADD nvarchar(250),
	@ACCOUNT_NGUOI_REMOVE nvarchar(35),
	@TEN_NGUOI_REMOVE nvarchar(250),
	@ID numeric(18, 0) OUTPUT
AS

INSERT INTO DM_BLACK_LIST
(
	-- ID -- this column value is auto-generated
	SO_DIEN_THOAI,
	ID_NGUOI_ADD,
	ID_NGUOI_REMOVE,
	NGAY_ADD,
	NGAY_REMOVE,
	ADD_YN
)
VALUES
(
	/* SO_DIEN_THOAI	*/@SO_DIEN_THOAI,
	/* ID_NGUOI_ADD	*/@ID_NGUOI_ADD,
	/* ID_NGUOI_REMOVE	*/@ID_NGUOI_REMOVE,
	/* NGAY_ADD	*/@NGAY_ADD,
	/* NGAY_REMOVE	*/NULL,
	/* ADD_YN	*/'Y'
)

SELECT @ID=SCOPE_IDENTITY()
GO
