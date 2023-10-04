using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OOPS.Console.Concepts.AsyncAwaits
{
    public class AsyncAwait
    {
        public async Task<int> PerformAsyncOperation()
        {
            await Task.Delay(1000);
            return 42;
        }
        
        public void CallAsyncOperation()
        {
            Task<int> task = PerformAsyncOperation();
            int result = task.Result; // Blocking call to retrieve the result

            Debug.WriteLine(result);
        }
        
        public async void ButtonClickEventHandler(object sender, EventArgs e)
        {
            
            // Start a concurrent operation
            Task.Run(ConcurrentOperation);

            try
            {
                // Perform an awaited operation (e.g., fetching data from a remote server)
                var result =  SomeAsyncOperation().Result;

                // Update the UI with the result
                //UpdateUI(result);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the awaited operation
                //ShowErrorMessage(ex.Message);
            }
        }

        private async Task<string> SomeAsyncOperation()
        {
            // Simulate a delay to represent a time-consuming operation
            await Task.Delay(3000);

            // Perform the actual operation (e.g., fetching data from a remote server)
            Debug.WriteLine("Data retrieved successfully!");
            return "yes";
        }

        private async Task ConcurrentOperation()
        {
            // This method represents a concurrent operation that can run simultaneously with the awaited operation
            await Task.Delay(1000);

            // Perform other tasks or operations here
            Debug.WriteLine("Update data in progress!");

            
        }

        private void UpdateOtherUIElements()
        {
            // Update other UI elements while the awaited operation is in progress
            //otherLabel.Text = "Updating other elements...";
        }

        private void PerformOtherTasks()
        {
            // Perform other tasks while the awaited operation is in progress
            // This could be any non-blocking operation or computation
            // ...
        }
    }
}