export interface Event {
  id: number;
  name: string;
  description: string;
  categoryId: number;
  category: {
    id: number;
    name: string;
  };
  venue: string;
  price: number;
  imageUrl?: string;
  date: string;
  numberOfTickets: number;
}
