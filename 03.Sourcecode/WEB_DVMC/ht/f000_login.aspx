<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f000_login.aspx.cs" Inherits="WEB_DVMC.hethong.f000_login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta content="IE=edge" http-equiv="X-UA-Compatible">
	<meta content="initial-scale=1.0, width=device-width" name="viewport">
	<title>Login - Material</title>

	<!-- css -->
    <link href="../Styles/css/base.min.css" rel="stylesheet" />
	<!-- css for this project -->
	<link href="../css/project.min.css" rel="stylesheet">
	<link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css" rel="stylesheet">

	<!-- favicon -->
	<!-- ... -->

	<!-- ie -->
		<!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
			<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body class="avoid-fout page-brand">
	<div class="avoid-fout-indicator avoid-fout-indicator-fixed">
		<div class="progress-circular progress-circular-center">
			<div class="progress-circular-wrapper">
				<div class="progress-circular-inner">
					<div class="progress-circular-left">
						<div class="progress-circular-spinner"></div>
					</div>
					<div class="progress-circular-gap"></div>
					<div class="progress-circular-right">
						<div class="progress-circular-spinner"></div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<header class="header header-brand">
		<span class="header-logo">DVMCv3.0</span>
	</header>
	<div class="content">
		<div class="container">
			<div class="row">
				<div class="col-lg-4 col-lg-push-4 col-sm-6 col-sm-push-3">
					<section class="content-inner">
						<div class="card-wrap">
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h1 class="card-heading">Login</h1>
										</div>
									</div>
									<div class="card-inner">
										<p class="text-center">
											<span class="avatar avatar-inline avatar-lg">
                                                <img src="../img/users/avatar-001.jpg" />
											</span>
										</p>
										<form class="form" action="index.html">
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-username">Tên đăng nhập</label>
														<asp:TextBox cssclass="form-control" id="login_username" runat="server" ></asp:TextBox>                                                           
													</div>
												</div>
											</div>
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-password">Password</label>
														<asp:TextBox cssclass="form-control" id="login_password" runat="server" TextMode="Password"></asp:TextBox>  
													</div>
												</div>
											</div>
                                            <div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="select_chi_nhanh">Chi nhánh</label>
                                                        <asp:DropDownList runat="server" cssclass="form-control" id="select_chi_nhanh">
                                                            <asp:ListItem Text="Hà Nội" />
                                                            <asp:ListItem Text="Đà Nẵng" />
                                                            <asp:ListItem Text="TP.Hồ Chí Minh" />
                                                        </asp:DropDownList>
														
													</div>
												</div>
											</div>
                                            <asp:Label ID="m_lab_error" runat="server"></asp:Label>

											<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<Asp:Button runat="server" ID="v_btn_su" cssclass="btn btn-block waves-attach waves-button" Text="Đăng nhập" OnClick="Unnamed1_Click"></Asp:Button>
													</div>
												</div>
											</div>
											<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<div class="checkbox checkbox-adv">
															<label for="login-remember">
																<input class="access-hide" id="login-remember" name="login-remember" type="checkbox">Ghi nhớ đăng nhập
																<span class="circle"></span><span class="circle-check"></span><span class="circle-icon icon">done</span>
															</label>
														</div>
													</div>
												</div>
											</div>
										</form>
									</div>
								</div>
							</div>
						</div>
						<div class="clearfix">
							<%--<p class="margin-no-top pull-left"><a class="btn btn-flat btn-blue waves-attach" href="javascript:void(0)">Need help?</a></p>
							<p class="margin-no-top pull-right"><a class="btn btn-flat btn-blue waves-attach" href="javascript:void(0)">Create an account</a></p>--%>
						</div>
					</section>
				</div>
			</div>
		</div>
	</div>
	<footer class="footer">
		<div class="container">
			<p>DVMCv3.0</p>
		</div>
	</footer>

	<!-- js -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="../Scripts/js/base.min.js"></script>
	<!-- js for this project -->
    <script src="../Scripts/js/project.min.js"></script>
</body>
</html>

