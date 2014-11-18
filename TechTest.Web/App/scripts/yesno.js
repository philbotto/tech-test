app.directive('yesNo', [function () {
    'use strict';

    return {
        restrict: 'A',
        scope: {
            yesNo: '='
        },
        link: function(scope, elem) {
            var cssClass;

            if (scope.yesNo) {
                cssClass = 'text-success';
                scope.text = 'Yes';
            } else {
                cssClass = 'text-danger';
                scope.text = 'No';
            }

            elem.addClass(cssClass);
        },
        template: "{{text}}",
    };
}]);
