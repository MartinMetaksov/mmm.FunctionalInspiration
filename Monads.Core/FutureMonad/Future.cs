// TODO: finish & optimise implementation
// namespace FunctionalInspiration.FutureMonad;
//
// class Future<T> where T : class
// {
//     private readonly Task<T> value;
//         
//     private Future(Task<T> value) 
//     {
//         this.value = value;
//     }
//         
//     public Future(T someValue) 
//     {
//         this.value = Task.FromResult(someValue);   
//     }
//
//     public Future<U> Bind<U>(Func<T, Future<U>> func) where U : class 
//     {
//         return new Future<U>(this.value.ContinueWith(t => func(t.Result).value).Unwrap());
//     }
//
//     public void OnComplete(Action<T> action) 
//     {
//         this.value.ContinueWith(t => action(t.Result));
//     }
// }