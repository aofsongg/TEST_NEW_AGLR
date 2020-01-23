<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("../Content/css")
    @Scripts.Render("../bundles/modernizr")
    <script src="../Scripts/angular.js"></script>
    <script src="../Scripts/angular-aria.js"></script>
    <script src="../Scripts/angular-animate.js"></script>
    <script src="../Scripts/angular-loader.js"></script>
    <script src="../Scripts/angular-messages.js"></script>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../V_ANGULARJS/MASTER_CTRL.js"></script>
    <script src="../V_ANGULARJS/CENTER_SV/CENTER_SERVICE.js"></script>
    <script src="../V_ANGULARJS/GATEWAY_CTRL.js"></script>
</head>
<body ng-app="MASTER_APP" ng-controller="GATEWAY_CTRL">
    <div class="navbar navbar-inverse navbar-fixed-top" style="background-color:red;font-size:medium">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
               {{FULL_MODEL.USERNAME}}
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><button ng-click="BTN_MENU(2)">LOGIN</button></li>
                    <li><button ng-click="BTN_MENU(1)">DETAIL_USER</button></li>
                    <li><button ng-click="BTN_MENU(555)">GGG</button></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
      <div ng-include="MAIN_PAGE">

      </div>

       
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
</body>
</html>
