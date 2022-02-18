class DisposePatternImplementer : CloseableResource, IDisposable
{
    private bool _disposed = false;
    private readonly IDisposable a;
    protected virtual void Dispose(bool disposing){
        if (!this._disposed){
            if(disposing){
                Console.WriteLine("Disposing by developer");
                a.Dispose();
            }
            else Console.WriteLine("Disposing by GC");
        }
        base.Close();
    }
    public void Dispose(){
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    ~DisposePatternImplementer(){}
}