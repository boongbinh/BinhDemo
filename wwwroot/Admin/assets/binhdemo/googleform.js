$(document).ready(function () {
    $('#add').click(function () {
        var html = '<div class="field-container" style="margin:40px 0">';
        html += '<div class="form-group">';
        html += '<label for="Name">Tên trường:</label>';
        html += '<input type="text" name="Name" class="form-control" />';
        html += '</div>';
        html += '<div class="form-group">';
        html += '<label for="Type">Định dạng:</label>';
        html += '<select id="FieldType" name="FieldType" class="form-control">';
        html += '<option value="Text">Text</option>';
        html += '<option value="Checkbox">Checkbox</option>';  
        html += '<option value="Radio">Radio</option>';
        html += '</select>';
        html += '</div>';
        html += '<div class="form-group">';
        html += '<label for="Name">Tên trường:</label>';
        html += '<input type="text" name="Name" class="form-control" />';
        html += '</div>';
        html += '<button type="button" class="btn btn-danger btn-xs remove" style="width=10%">Xóa</button>'; // Thêm nút "X" close
        html += '</div>';
        $('#fieldsContainer').append(html);
    });

    // Xử lý sự kiện click của nút "X" close
    // $(document).on('click', '.remove', function () {
    //     $(this).closest('.form-group').remove(); // Xóa div cha của nút được nhấn
    // });
    $(document).on('click', '.remove', function () {
        $(this).closest('.field-container').remove(); // Xóa div cha của nút được nhấn
    });

    $('#FieldType').change(function () {
        var selectedOption = $(this).val();
        if (selectedOption === "Checkbox") {
            $('#checkboxFields').show();
            $('#radioFields').hide();
        } else if (selectedOption === "Radio") {
            $('#checkboxFields').hide();
            $('#radioFields').show();
        } else {
            $('#checkboxFields').hide();
            $('#radioFields').hide();
        }
    });
});