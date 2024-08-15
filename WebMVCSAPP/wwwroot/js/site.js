function GetCountries() {
    $.ajax({
        url: window.location.origin + '/Home/GetCountries',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            var selectCountries = $('#countries');

            selectCountries.empty();

            var optionSelected = $('<option></option>');
            optionSelected.text('Seleccione un país');
            optionSelected.val(0);
            optionSelected.prop('selected', true);

            selectCountries.append(optionSelected);

            for (var i = 0; i < data.length; i++) {
                var option = $('<option></option>');
                option.text(data[i].name);
                option.val(data[i].id);
                selectCountries.append(option);
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function GetDepStaProsByCountry() {
    var countryId = 1;
    $.ajax({
        url: window.location.origin + '/Home/GetDepStaProsByCountry?countryId=' + countryId,
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
}



$(document).ready(function () {
    GetCountries();
});
