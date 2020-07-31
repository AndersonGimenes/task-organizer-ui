function createTask(){
    var  data = {
        taskNumber: 0,
        title: $('#title').val(),
        description: $('#description').val(),
        progress: 'ToDo',
        estimatedDate: $('#estimatedDate').val()
    }   

    $.ajax({
        url : "https://localhost:5001/Task/CreateTask",
        type : 'post',
        data : data
    })
    .done(function(){
        alert("Success")
    });
}

