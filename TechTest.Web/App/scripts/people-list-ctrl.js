app.controller('PeopleListCtrl', ['$scope', '$http', function ($scope, $http) {
    'use strict';

    $http.get('/api/people').then(function (result) {
        $scope.people = result.data;
    });

}]);
