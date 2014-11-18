app.config(['$routeProvider', function ($routeProvider) {
    'use strict';
    
    $routeProvider.
      when('/people', {
          templateUrl: '/app/views/people-list.html',
          controller: 'PeopleListCtrl'
      }).
      when('/people/:id', {
          templateUrl: '/app/views/people-detail.html',
          controller: 'PeopleDetailCtrl'
      }).
      otherwise({
          redirectTo: '/people'
      });

}]);
