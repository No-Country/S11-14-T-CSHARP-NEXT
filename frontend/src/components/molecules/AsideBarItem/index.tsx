import ItemIconMenu from '@components/molecules/ItemIconMenu';

interface AsideBarItemProps {
  itemName: string;
  itemIcon: string;
}

const AsideBarItem: React.FC<AsideBarItemProps> = ({ itemName, itemIcon }) => {
  return (
    <div className='flex items-center font-roboto my-4 text-white cursor-pointer'>
      <ItemIconMenu iconType={itemIcon} className='float-left mr-2' /> <span>{itemName}</span>
    </div>
  );
};

export default AsideBarItem;
