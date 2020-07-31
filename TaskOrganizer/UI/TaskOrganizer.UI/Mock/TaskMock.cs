using System.Collections.Generic;
using Newtonsoft.Json;
using TaskOrganizer.UI.Models;

namespace TaskOrganizer.UI.Mock
{
    public static class TaskMock
    {
        public static List<TaskModel> GetTaskMock()
        {
            var json = dataMock;
            return JsonConvert.DeserializeObject<List<TaskModel>>(json);
        }

        //private static string dataMock = string.Empty;
        private static string dataMock = 
        @"[
            {
                'taskNumber': 53,
                'title': 'Teste 1',
                'description': 'Teste 1',
                'progress': 'ToDo',
                'createDate': '2020-07-18T00:00:00',
                'estimatedDate': '2020-09-30T00:00:00',
                'startDate': null,
                'endDate': null
            },
            {
                'taskNumber': 54,
                'title': 'Teste 2',
                'description': 'Teste 2',
                'progress': 'ToDo',
                'createDate': '2020-07-18T00:00:00',
                'estimatedDate': '2020-09-30T00:00:00',
                'startDate': null,
                'endDate': null
            },
            {
                'taskNumber': 56,
                'title': 'Teste 3',
                'description': 'Teste 3',
                'progress': 'InProgress',
                'createDate': '2020-07-18T00:00:00',
                'estimatedDate': '2020-09-30T00:00:00',
                'startDate': '2020-07-18T00:00:00',
                'endDate': null
            },
            {
                'taskNumber': 62,
                'title': 'Teste 2.3',
                'description': 'Teste 2.399',
                'progress': 'Done',
                'createDate': '2020-07-18T00:00:00',
                'estimatedDate': '2020-09-30T00:00:00',
                'startDate': '2020-07-18T00:00:00',
                'endDate': '2020-07-18T00:00:00'
            }]";
    }   
}   