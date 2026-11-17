// Демонстрационная форма заявки: проверка полей в браузере,
// данные никуда не отправляются.
(function () {
    "use strict";

    var form = document.getElementById("contactForm");
    if (!form) {
        return;
    }

    // Дополнительная проверка телефона в скрипте: если браузер не поддержит
    // атрибут pattern, неверный номер всё равно не пройдёт
    var phone = document.getElementById("cf-phone");
    function checkPhone() {
        var ok = /^[0-9+()\- ]{6,20}$/.test(phone.value.trim());
        phone.setCustomValidity(ok ? "" : "Неверный телефон");
    }
    if (phone) {
        phone.addEventListener("input", checkPhone);
    }

    form.addEventListener("submit", function (event) {
        event.preventDefault();
        event.stopPropagation();
        if (phone) {
            checkPhone();
        }

        form.classList.add("was-validated");
        if (!form.checkValidity()) {
            return;
        }

        var done = document.getElementById("formDone");
        if (done) {
            done.classList.remove("d-none");
        }
        form.reset();
        form.classList.remove("was-validated");
    });
})();
