/*global $,ko */
(function ($, ko) {
    var appViewModel = {
        TotalPrice: ko.observable(0),
        DiscountPrice: ko.observable(0),
        CalculateDiscountPrice: function () {
            var self = this;
            $.ajax({
                url: "/Calculate/CalculateDiscount",
                type: "POST",
                data: { totalPrice: this.TotalPrice() },
                success: function (response) {
                    self.DiscountPrice(response.DiscountPrice);
                }
            });
        }
    };

    ko.applyBindings(appViewModel);
})($, ko);