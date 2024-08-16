function GetCountries() {
    $.ajax({
        url: window.location.origin + '/Users/GetCountries',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            var selectPaises = $('#paises');

            selectPaises.empty();

            var optionSelected = $('<option></option>');
            optionSelected.text('Seleccione un país');
            optionSelected.val(0);
            optionSelected.prop('selected', true);

            selectPaises.append(optionSelected);

            for (var i = 0; i < data.length; i++) {
                var option = $('<option></option>');
                option.text(data[i].name);
                option.val(data[i].id);
                selectPaises.append(option);
            }   
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function GetDepStaProsByCountry() {
    $('#error-pais').addClass('d-none');
    var countryId = $('#paises option:selected').val();
    $.ajax({
        url: window.location.origin + '/Users/GetDepStaProsByCountry?countryId=' + countryId,
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            var selectDepartamentos = $('#departamentos');
            selectDepartamentos.prop('disabled', false);

            selectDepartamentos.empty();

            var optionSelected = $('<option></option>');
            optionSelected.text('Seleccione un departamento');
            optionSelected.val(0);
            optionSelected.prop('selected', true);

            selectDepartamentos.append(optionSelected);

            for (var i = 0; i < data.length; i++) {
                var option = $('<option></option>');
                option.text(data[i].name);
                option.val(data[i].id);
                selectDepartamentos.append(option);
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function GetCitMunsByDepStaPro() {
    $('#error-departamento').addClass('d-none');
    var depStaProId = $('#departamentos').val();
    $.ajax({
        url: window.location.origin + '/Users/GetCitMunsByDepStaPro?depStaProId=' + depStaProId,
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            var selectCiudadesOMunicipios = $('#ciudadesOMunicipios');
            selectCiudadesOMunicipios.prop('disabled', false);
            selectCiudadesOMunicipios.empty();

            var optionSelected = $('<option></option>');
            optionSelected.text('Seleccione una ciudad o municipio');
            optionSelected.val(0);
            optionSelected.prop('selected', true);

            selectCiudadesOMunicipios.append(optionSelected);

            for (var i = 0; i < data.length; i++) {
                var option = $('<option></option>');
                option.text(data[i].name);
                option.val(data[i].id);
                selectCiudadesOMunicipios.append(option);
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function DisabledFalseSelectDocumentTypes() {
    $('#error-ciudad-municipio').addClass('d-none');
    var selectDocumentoIdentidad = $('#tiposDocumentoIdentidad');
    selectDocumentoIdentidad.prop('disabled', false);
}

function RemoveDocumentTypeError() {
    $('#error-tipo-documento').addClass('d-none');
}

function GetDocumentTypes() {
    $.ajax({
        url: window.location.origin + '/Users/GetDocumentTypes',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            var selectDocumentoIdentidad = $('#tiposDocumentoIdentidad');

            selectDocumentoIdentidad.empty();

            var optionSelected = $('<option></option>');
            optionSelected.text('Seleccione su tipo de documento');
            optionSelected.val(0);
            optionSelected.prop('selected', true);

            selectDocumentoIdentidad.append(optionSelected);

            for (var i = 0; i < data.length; i++) {
                var option = $('<option></option>');
                option.text(data[i].name);
                option.val(data[i].id);
                selectDocumentoIdentidad.append(option);
            } 
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function CleanFormRegisterUser() {
    $('#primer-nombre').val("");
    $('#segundo-nombre').val("");
    $('#primer-apellido').val("");
    $('#segundo-apellido').val("");
    $('#email').val("");
    $('#celular').val("");
    $('#paises').val('0');
    $('#departamentos').val('0').prop('disabled', true);
    $('#ciudadesOMunicipios').val('0').prop('disabled', true);
    $('#tiposDocumentoIdentidad').val('0').prop('disabled', true);
    $('#numero-documento').val("");
    $('#terminos-condiciones').prop('checked', false);
}

function UserRegister() {
    var primerNombre = $('#primer-nombre').val();
    var segundoNombre = $('#segundo-nombre').val();
    var primerApellido = $('#primer-apellido').val();
    var segundoApellido = $('#segundo-apellido').val();
    var email = $('#email').val();
    var celular = $('#celular').val();
    var paisId = $('#paises').val();
    var departamentoId = $('#departamentos').val();
    var ciudadoMunicipioId = $('#ciudadesOMunicipios').val();
    var documentoId = $('#tiposDocumentoIdentidad').val();
    var numeroDocumento = $('#numero-documento').val();
    var terminosCondiciones = $('#terminos-condiciones').prop('checked');
    
    if (primerNombre === "") {
        $('#error-primer-nombre').removeClass('d-none');
    } else {
        $('#error-primer-nombre').addClass('d-none');
        if (primerApellido === "") {
            $('#error-primer-apellido').removeClass('d-none');
        } else {
            $('#error-primer-apellido').addClass('d-none');
            if (email === "") {
                $('#error-email').removeClass('d-none');
            } else {
                $('#error-email').addClass('d-none');
                if (celular === "") {
                    $('#error-celular').removeClass('d-none');
                } else {
                    $('#error-celular').addClass('d-none');
                    if (paisId == 0) {
                        $('#error-pais').removeClass('d-none');
                    } else {
                        $('#error-pais').addClass('d-none');
                        if (departamentoId == 0) {
                            $('#error-departamento').removeClass('d-none');
                        } else {
                            $('#error-departamento').addClass('d-none');
                            if (ciudadoMunicipioId == 0) {
                                $('#error-ciudad-municipio').removeClass('d-none');
                            } else {
                                $('#error-ciudad-municipio').addClass('d-none');
                                if (documentoId == 0) {
                                    $('#error-tipo-documento').removeClass('d-none');
                                } else {
                                    $('#error-tipo-documento').addClass('d-none');
                                    if (numeroDocumento === "") {
                                        $('#error-numero-documento').removeClass('d-none');
                                     } else {
                                        $('#error-numero-documento').addClass('d-none');
                                        if (!terminosCondiciones) {
                                            $('#error-terminos-condiciones').removeClass('d-none');
                                        } else {
                                            $('#error-terminos-condiciones').addClass('d-none');

                                            var userData = {
                                                FirstName: primerNombre,
                                                MiddleName: segundoNombre,
                                                LastName: primerApellido,
                                                MiddleLastName: segundoApellido,
                                                IdentificationTypeDocumentId: documentoId,
                                                IdentificationDocumentNumber: numeroDocumento,
                                                CountryId: paisId,
                                                StaProDepId: departamentoId,
                                                CityId: ciudadoMunicipioId,
                                                Email: email,
                                                Phone: celular
                                            }

                                            $.ajax({
                                                url: window.location.origin + '/Users/UserRegister',
                                                method: 'POST',
                                                contentType: 'application/json',
                                                data: JSON.stringify(userData),
                                                success: function (data) {
                                                    console.log(data);
                                                },
                                                error: function (error) {
                                                    console.log(error);
                                                }
                                            });
                                        }
                                    }
                                }   
                            }   
                        }
                    }
                }
            }
        }
    }
}

$(document).ready(function () {
    GetCountries();
    GetDocumentTypes();
});
