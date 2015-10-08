<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f000_login.aspx.cs" Inherits="WEB_DVMC.hethong.f000_login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta content="IE=edge" http-equiv="X-UA-Compatible" />
    <meta content="initial-scale=1.0, width=device-width" name="viewport" />
    <title>
	Login - Material
</title>

	<!-- css -->
    <link href="../Styles/css/base.min.css" rel="stylesheet" />
	<!-- favicon -->
	<!-- ... -->

	<!-- ie -->
		<!--[if lt IE 9]>
			<script src="js/html5shiv.js" type="text/javascript"></script>
			<script src="js/respond.js" type="text/javascript"></script>
		<![endif]-->
</head>
<body>
    <div>
           <header class="header">
		<div class="clearfix pull-left">
			<span class="header-logo margin-left">DVMC3.0</span>
		</div>
	</header>
	<div class="content">
		<div class="content-heading">
		</div>
		<div class="content-inner">
			<div class="container">
				<div class="row">
					<div class="col-lg-4 col-lg-push-4 col-sm-6 col-sm-push-3 col-xs-10 col-xs-push-1">
						<div class="card-wrap">
							<div class="card">
								<div class="card-main">
									<div class="card-header">
										<div class="card-inner">
											<h1 class="card-heading">Đăng nhập</h1>
										</div>
									</div>
									<div class="card-inner">
										<p class="text-center">
											<span class="avatar avatar-inline avatar-lg">
                                                <img src="../img/users/avatar-001.jpg" />
											</span>
										</p>
										<form class="form" action="index.html" >
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-username">Tên truy cập</label>
														<input class="form-control" id="login-username" type="text" />
													</div>
												</div>
											</div>
											<div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="login-password">Password</label>
														<input class="form-control" id="login-password" type="password"  />
													</div>
												</div>
											</div>
                                            <div class="form-group form-group-label">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<label class="floating-label" for="chi_nhanh">Chi nhánh</label>
														<select class="form-control" id="input-select">
										                    <option>Hà Nội</option>
										                    <option>Đà Nẵng</option>
										                    <option>Hồ Chí Minh</option>
									                    </select>
													</div>
												</div>
											</div>
											<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<button class="btn btn-block btn-blue waves-button waves-effect waves-light">Đăng nhập</button>
													</div>
												</div>
											</div>
											<%--<div class="form-group">
												<div class="row">
													<div class="col-md-10 col-md-push-1">
														<div class="checkbox checkbox-adv">
															<label for="login-remember">
															<input class="access-hide" id="login-remember" name="login-remember" type="checkbox" checked="checked" />Ghi nhớ đăng nhập
															</label>
														</div>
													</div>
												</div>
											</div>--%>
										</form>
									</div>
								</div>
							</div>
						</div>
						<div class="clearfix">
							<%--<p class="margin-no-top pull-left"><a href="javascript:void(0)">Trợ giúp?</a></p>
							<p class="margin-no-top pull-right"><a href="javascript:void(0)">Đăng ký</a></p>--%>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<footer class="footer">
		<div class="container">
			<p>DVMC3.0</p>
		</div>
	</footer>
        <script src="../Scripts/js/base.min.js"></script>
    </div>  
</body>
</html>
