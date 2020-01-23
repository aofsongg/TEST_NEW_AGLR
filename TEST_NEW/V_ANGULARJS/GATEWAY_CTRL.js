app.controller('GATEWAY_CTRL', function ($scope, $http, $location, CENTER_SERVICE) {
    $scope.FULL_MODEL = [];
    $scope.MAIN_PAGE = '../MYVIEW/Login_menu';
    $scope.USERNAME = "";
    $scope.PASSWORD = "";
    $scope.NAME = 'นน แบร์';
    LOAD_MODEL();

    function CLEAR_DATA() {
        $scope.FULL_MODEL.USERNAME = "";
        $scope.FULL_MODEL.PASSWORD = "";
    };

    $scope.BTN_CLEAR = function () {
        $scope.FULL_MODEL.USERNAME = "";
        $scope.FULL_MODEL.PASSWORD = "";
    };
    $scope.SEL_DATA = function (DATA) {
        $scope.FULL_MODEL.USERNAME = DATA.USERNAME;
        $scope.FULL_MODEL.PASSWORD = DATA.PASSWORD;
        $scope.FULL_MODEL.CLS_TABLE_USER.USERNAME = DATA.USERNAME;
        $scope.FULL_MODEL.CLS_TABLE_USER.PASSWORD = DATA.PASSWORD;
    }

    function LOAD_MODEL() {
 
        var getdata = CENTER_SERVICE.GET_FULL_MODEL();
        getdata.then(function (datas) {
            if (datas.data.length !== 0) {
                $scope.FULL_MODEL = datas.data;
            };
        }, function () {
            alert($scope.error_message);
        });

    };

    $scope.BTN_MENU = function (MENU_ID) {
        if (MENU_ID == '1') {
            $scope.MAIN_PAGE = '../MYVIEW/DETAIL_USER';
        } else if (MENU_ID == '2') {
            $scope.MAIN_PAGE = '../MYVIEW/Login_menu';
        } else {
            $scope.MAIN_PAGE = '../MYVIEW/Login_menu';
        }
    };

    $scope.PAGE_BACK = "";

    $scope.BTN_LOGIN = function () {
        $scope.FULL_MODEL.FUNC_CODE = "FUNC-CHK_UP-001";
        var getdata = CENTER_SERVICE.GET_DATA_CENTER($scope.FULL_MODEL);
        getdata.then(function (datas) {
            if (datas.data.length !== 0) {
                $scope.PAGE_BACK = $scope.MAIN_PAGE;
                if ($scope.FULL_MODEL.USERNAME == "ADMIN" && datas.data.RESULT_FUNC == "SUCCESS") {
                    alert("เข้าด้วยสิทธิ Admin");
                } else if (datas.data.RESULT_FUNC == "SUCCESS") {
                    alert("เข้าด้วยสิทธิ USER");
                } else {
                    alert(datas.data.RESULT_FUNC);
                }
            };
        }, function () {
            alert($scope.error_message);
        });

       
    };

    $scope.BTN_BACK = function () {
        $scope.MAIN_PAGE = $scope.PAGE_BACK;
    };


    $scope.BTN_REGISTER = function (USER, PASS) {
        $scope.FULL_MODEL.CLS_TABLE_USER.USERNAME = USER;
        $scope.FULL_MODEL.CLS_TABLE_USER.PASSWORD = PASS;
        $scope.FULL_MODEL.FUNC_CODE = "FUNC-RGT-001";
        var getdata = CENTER_SERVICE.GET_DATA_CENTER($scope.FULL_MODEL);
        getdata.then(function (datas) {
            if (datas.data.length !== 0) {
                $scope.PAGE_BACK = $scope.MAIN_PAGE;
                if (datas.data.RESULT_STR == "SUCCESS") {
                    alert("สมัครสมาชิกเรียบร้อยแล้ว");
                    $scope.FULL_MODEL.DETAIL_DATA = datas.data.RESULT_FUNC;
                    CLEAR_DATA();
                }  else {
                    alert(datas.data.RESULT_STR);
                }
                CLEAR_DATA();
            };
        }, function () {
            alert($scope.error_message);
            });
    };
    $scope.BTN_SEL= function () {
        $scope.FULL_MODEL.FUNC_CODE = "FUNC-SEL-001";
        var getdata = CENTER_SERVICE.GET_DATA_CENTER($scope.FULL_MODEL);
        getdata.then(function (datas) {
            if (datas.data.RESULT_FUNC.length !== 0) {
                $scope.FULL_MODEL.USERNAME = datas.data.RESULT_FUNC.USERNAME;
                $scope.FULL_MODEL.PASSWORD = datas.data.RESULT_FUNC.PASSWORD;
                $scope.FULL_MODEL.CLS_TABLE_USER.USERNAME = datas.data.RESULT_FUNC.USERNAME;
                $scope.FULL_MODEL.CLS_TABLE_USER.PASSWORD = datas.data.RESULT_FUNC.PASSWORD;
                alert("พบข้อมูล")
            } else {
                alert("ไม่พบข้อมูล");
            };
        }, function () {
            alert($scope.error_message);
        });
    };
    $scope.BTN_EDIT = function () {
        $scope.FULL_MODEL.FUNC_CODE = "FUNC-EDIT-001";
        var getdata = CENTER_SERVICE.GET_DATA_CENTER($scope.FULL_MODEL);
        getdata.then(function (datas) {
            if (datas.data.RESULT_FUNC.length !== 0) {
                if (datas.data.RESULT_STR == "SUCCESS"){
                    alert("แก้ไขเรียบร้อยแล้ว")
                }
            } else {
                alert(datas.data.RESULT_STR);
            };
            CLEAR_DATA();
        }, function () {
            alert($scope.error_message);
        });
    };
    $scope.BTN_DEL = function (USER) {
        $scope.FULL_MODEL.USERNAME = USER;
        $scope.FULL_MODEL.FUNC_CODE = "FUNC-DEL-001";
        var getdata = CENTER_SERVICE.GET_DATA_CENTER($scope.FULL_MODEL);
        getdata.then(function (datas) {
            if (datas.data.RESULT_FUNC.length !== 0) {
                if (datas.data.RESULT_FUNC == "SUCCESS") {
                    alert("ลบเรียบร้อยแล้ว")
                } else {
                    alert(datas.data.RESULT_FUNC);
                }
            } else {
                alert(datas.data.RESULT_FUNC);
            };
            CLEAR_DATA();
        }, function () {
            alert($scope.error_message);
        });
    };


});