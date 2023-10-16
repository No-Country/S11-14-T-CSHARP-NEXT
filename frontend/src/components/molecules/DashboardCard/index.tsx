import DashboardIcon from '../DashboardIcon';

interface DashboardCardProps {
  icon: string;
  number: string;
  title: string;
  className?: string;
}

const DashboardCard: React.FC<DashboardCardProps> = (props) => {
  return (
    <div className='flex flex-col justify-center items-center'>
      <DashboardIcon className={props.className} iconType={props.icon} size='50' />
      <h2 className='text-[26px] text-black mb-[10px]'>{props.number}</h2>
      <h3 className='text-lg text-black'>{props.title}</h3>
    </div>
  );
};

export default DashboardCard;
