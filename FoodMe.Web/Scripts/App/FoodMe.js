var FoodMe = {
    utilities: {}
    , layout: {}
    , page: {
        handlers: {
        }
        , startUp: null
    }
    , services: {}
    , ui: {}
};

FoodMe.moduleOptions = {
    APPNAME: "FoodMeApp"
    , extraModuleDependencies: []
    , runners: []
    , page: FoodMe.page//we need this object here for later use
};

FoodMe.layout.startUp = function () {

    console.debug("FoodMe.layout.startUp");

    //this does a null check on sabio.page.startUp
    if (FoodMe.page.startUp) {
        console.debug("FoodMe.page.startUp");
        FoodMe.page.startUp();
    }
};

FoodMe.APPNAME = "FoodMeApp";//legacy
$(document).ready(FoodMe.layout.startUp);