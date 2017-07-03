(function () {

    'use strict';

    angular.module('FoodMeApp')
        .factory('peopleService', peopleServiceFactory);

    function peopleServiceFactory() {

        var aPeopleServiceObject = FoodMe.services.people;
        console.log('People Service created successfully');
        return aPeopleServiceObject;

    };

})();