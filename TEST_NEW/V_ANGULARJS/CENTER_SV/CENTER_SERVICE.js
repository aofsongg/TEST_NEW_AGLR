app.service("CENTER_SERVICE", function ($http) {

  
    this.GET_FULL_MODEL = function () {
        return $http.get("../DATA_CENTER/GET_FULL_MODEL");
    };

    this.GET_DATA_CENTER = function (MODEL) {
        var response = $http({
            method: "post",
            url: "../DATA_CENTER/GATEWAY_DATA",
            dataType: "json",
            data : {
                MODEL: MODEL
            }
        });
        return response;
    };



});