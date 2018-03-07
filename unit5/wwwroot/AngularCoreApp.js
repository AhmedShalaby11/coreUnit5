var app = angular.module('angularApp', []);

// 

app.controller('registrationController', function ($scope, $http) {

    // Doctor professional info configuration.
    $scope.doctorPrecense = ["Available", "Abroad"];

    $scope.test = "test yalaaaa";
    //

    //API for user registration.

    $scope.regREQ = function (n, t, od, oq, deg, prec) {
        var bYear = $("#dp1519323288841").val();
        var pYear = $("#dp1519323288843").val();
        var mYear = $("#dp1519323288842").val();
        var bdate = $("#dp1519323288840").val();

        //    name,date of birth,title,other degrees,other qualifications,degree,bach-mcs-phd year,precense 
        $http.get('./API_insertDoctorProfile?method=insertDoctorProfile&n=' + n + '&d=' + bdate + '&t=' + t + '&od=' + od + '&oq=' + oq + '&deg=' + deg + '&bdate=' + bYear + '&mdate=' + mYear + '&pdate=' + pYear + '&prec=' + prec + '').then(function (response) {
            console.log(response.data + "-" + response.status);
        });
    };

});