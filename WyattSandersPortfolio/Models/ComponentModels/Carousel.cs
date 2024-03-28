namespace WyattSandersPortfolio.Models.ComponentModels
{
    public class Carousel
    {
        public int ActiveIndex { get; private set; }
        public int NumPages = -1;
        Action? OnUpdateIndex;
        //bool isautoAdvancingCarosel = true;

        public Carousel(int pages,Action onUpdateIndex) {
            ActiveIndex = 0;
            NumPages = pages;
            OnUpdateIndex = onUpdateIndex;
        }
        /*
        public async Task AutoAdvanceCarosel()
        {
            await Task.Delay(2500);
            while (isautoAdvancingCarosel)
            {
                SetCaroselIndex(ActiveIndex + 1);
                await Task.Delay(2500);
            }
        }*/
        public void Next(bool wrapAround = false)
        {
            SetCaroselIndex(ActiveIndex+1, wrapAround);
        }
        public void Previous(bool wrapAround = false)
        {
            SetCaroselIndex(ActiveIndex-1,wrapAround);
        }
        public void SetCaroselIndex(int newIndex, bool wrapAround = false)
        {
            if (NumPages <= 0)
            {
                return;
            }
            if (newIndex >= NumPages)
            {
                newIndex = wrapAround? 0:NumPages - 1;
            }
            else if (newIndex < 0)
            {
                newIndex = wrapAround ? NumPages - 1 : 0;
            }

            ActiveIndex = newIndex;
            OnUpdateIndex?.Invoke();
        }
    }
}
