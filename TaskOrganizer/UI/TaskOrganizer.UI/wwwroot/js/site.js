function createTask(){
    var  data = {
        taskNumber: 0,
        title: $('#title').val(),
        description: $('#description').val(),
        progress: 'ToDo',
        estimatedDate: $('#estimatedDate').val()
    }   

    $.ajax({
        url : "https://localhost:6001/Task/CreateTask",
        type : 'post',
        data : data,
        success: function(){
            $('#exampleModal').modal('hide')
            location.reload();
        }, 
        error: function(){
            console.log('Application error!')
        }
    });
}

