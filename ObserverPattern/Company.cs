using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObserverPattern
{
    class Company
    {
        private List<Candidate> candidates;
        private ObservableCollection<Opportunity> opportunities;

        public Company()
        {
            this.candidates = new List<Candidate>();
            this.opportunities = new ObservableCollection<Opportunity>();

            this.opportunities.CollectionChanged += CollectionChangedEvent;
        }

        public void CollectionChangedEvent(object sender, NotifyCollectionChangedEventArgs eventArgs)
        {
            if (eventArgs.Action == NotifyCollectionChangedAction.Add)
            {
                this.candidates.ForEach(candidate => candidate.Notify(((Opportunity)eventArgs.NewItems[0]).Name));
            }
        }

        public void AddCandidates(Candidate candidate)
        {
            this.candidates.Add(candidate);
        }

        public void RemoveCandidates(Candidate candidate)
        {
            this.candidates.Remove(candidate);
        }
        public void AddOpportunity(Opportunity opportunity)
        {
            this.opportunities.Add(opportunity);
        }
    }
}
