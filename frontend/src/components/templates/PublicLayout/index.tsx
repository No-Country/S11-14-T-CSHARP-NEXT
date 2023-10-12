'use client';
interface PublicLayoutProps {
  children: React.ReactNode;
}

const PublicLayout: React.FC<PublicLayoutProps> = ({ children }) => {
  return <section>{children}</section>;
};

export default PublicLayout;
