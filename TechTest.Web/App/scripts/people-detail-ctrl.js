app.controller('PeopleDetailCtrl', ['$scope', '$http', '$routeParams', '$location', function ($scope, $http, $routeParams, $location) {
    'use strict';

    $http.get('/api/people/' + $routeParams.id).then(function (result) {
        $scope.person = result.data;
    });

    $http.get('/api/colours').then(function (result) {
        $scope.colours = result.data;
    });

    $scope.submit = function (person) {
        $scope.submitting = true;

        $http.put('/api/people/' + person.personId, person).then(function () {
            $location.path('/people');
        }, function() {
            $scope.submitting = false;
        });
    };

    $scope.isSelected = function (colours, colour) {
        var match = false;

        angular.forEach(colours, function (value) {
            if (value.colourId === colour.colourId) {
                match = true;
                return;
            }
        });

        return match;
    };

    $scope.select = function (colours, colour) {
        if ($scope.isSelected(colours, colour)) {
            var index = false;

            angular.forEach(colours, function (value, key) {
                if (value.colourId === colour.colourId) {
                    index = key;
                    return;
                }
            });

            colours.splice(index, 1);
        } else {
            colours.push(colour);
        }
    };

    $scope.cancel = function () {
        $location.path('/people');
    };

}]);
